using Newtonsoft.Json;
using Paint_FinalProject.Commands;
using Paint_FinalProject.Models;
using Paint_FinalProject.ToolsLibrary;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Paint_FinalProject
{
    public partial class Form1 : Form
    {
        private Bitmap _mainBitmap;
        private Bitmap _tempBitmap;
        private Graphics _graphics;

        private string _projectName;
        private string _projectPath;

        private int _currentToolIndex = 1;
        private Color _currentColor = Color.Black;
        private float _currentThickness = 2f;

        private Point _startPoint;
        private bool _isDrawing = false;
        private Shape _currentFreehandShape;

        private bool _isBold = false, _isItalic = false, _isUnderline = false;
        private float _zoomFactor = 1.0f;
        private PointF _offset = new PointF(0, 0);

        private HistoryManager _historyManager;

        public Form1(string projectName, string loadPath = null)
        {
            InitializeComponent();
            _projectName = projectName;
            _projectPath = loadPath;

            this.Text = $"Paint - {_projectName}";

            SetupCanvas();

            if (!string.IsNullOrEmpty(_projectPath))
            {
                LoadProjectData(_projectPath);
            }
        }

        private void SetupCanvas()
        {
            panelTextOptions.Visible = false;

            _mainBitmap = new Bitmap(picture.Width, picture.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.SmoothingMode = SmoothingMode.AntiAlias;
            _graphics.Clear(Color.White);

            picture.Image = _mainBitmap;
            _historyManager = new HistoryManager(_mainBitmap);

            if (color_picker?.Image != null && !(color_picker.Image is Bitmap))
            {
                color_picker.Image = new Bitmap(color_picker.Image);
            }

            comboBoxFonts.Items.Clear();
            foreach (FontFamily font in FontFamily.Families)
                comboBoxFonts.Items.Add(font.Name);

            comboBoxFonts.SelectedItem = comboBoxFonts.Items.Contains("Arial") ? "Arial" :
                                         (comboBoxFonts.Items.Count > 0 ? comboBoxFonts.Items[0] : null);

            UpdateDrawingColor(Color.Black);
            picture.Invalidate();
        }

        // ЗАРЕФАКТОРИНИЙ МЕТОД: Тепер він виконує лише високорівневу маршрутизацію завантаження
        private void LoadProjectData(string path)
        {
            try
            {
                string extension = Path.GetExtension(path).ToLower();

                if (extension == ".json")
                {
                    LoadJsonProject(path);
                }
                else if (IsRasterImageExtension(extension))
                {
                    LoadRasterImage(path);
                }

                RefreshHistoryList();
                picture.Invalidate();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Íå âäàëîñÿ â³äêðèòè ôàéë: {ex.Message}");
            }
        }

        // ВИТЯГНУТИЙ МЕТОД: Відповідає тільки за роботу з JSON-файлами проєктів
        private void LoadJsonProject(string path)
        {
            string json = File.ReadAllText(path);
            var settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };
            var project = JsonConvert.DeserializeObject<DrawingProject>(json, settings);

            if (project != null && project.Shapes != null)
            {
                _graphics.Clear(Color.White);
                _historyManager.ClearHistory();
                foreach (var shape in project.Shapes)
                {
                    shape.Draw(_graphics);
                    var command = new DrawCommand(shape, _mainBitmap, "Çàâàíòàæåíî");
                    _historyManager.ExecuteCommand(command, _graphics);
                }
            }
        }

        // ВИТЯГНУТИЙ МЕТОД: Відповідає тільки за імпорт растрових зображень
        private void LoadRasterImage(string path)
        {
            using (Image img = Image.FromFile(path))
            {
                _graphics.Clear(Color.White);
                _graphics.DrawImage(img, 0, 0, _mainBitmap.Width, _mainBitmap.Height);

                Bitmap snapshot = new Bitmap(_mainBitmap);
                var command = new DrawCommand(new ImageShape(new Point(0, 0), snapshot), _mainBitmap, "²ìïîðò ôîòî");
                _historyManager.ExecuteCommand(command, _graphics);
            }
        }

        private bool IsRasterImageExtension(string extension)
        {
            return extension == ".png" || extension == ".jpg" || extension == ".jpeg" || extension == ".bmp";
        }

        private void SaveProject(string filePath)
        {
            var project = new DrawingProject
            {
                Name = Path.GetFileNameWithoutExtension(filePath),
                LastModified = DateTime.Now,
                Shapes = _historyManager.GetShapesForSave(),
                CanvasWidth = _mainBitmap.Width,
                CanvasHeight = _mainBitmap.Height
            };

            string json = JsonConvert.SerializeObject(project, new JsonSerializerSettings
            {
                TypeNameHandling = TypeNameHandling.All,
                Formatting = Formatting.Indented
            });

            File.WriteAllText(filePath, json);
        }

        private Font GetCurrentFont()
        {
            string fontName = comboBoxFonts.SelectedItem?.ToString() ?? "Arial";
            float fontSize = (float)numericFontSize.Value;

            FontStyle style = FontStyle.Regular;

            if (_isBold) style |= FontStyle.Bold;
            if (_isItalic) style |= FontStyle.Italic;
            if (_isUnderline) style |= FontStyle.Underline;

            return new Font(fontName, fontSize, style);
        }

        private void UpdateDrawingColor(Color newColor)
        {
            _currentColor = newColor;

            if (button_color != null)
            {
                button_color.BackColor = newColor;
            }
        }

        private string ShowTextInputDialog()
        {
            Form prompt = new Form()
            {
                Width = 350,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = "Ââåä³òü òåêñò äëÿ ìàëþâàííÿ",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false
            };

            TextBox textBox = new TextBox() { Left = 20, Top = 20, Width = 290 };
            Button confirmation = new Button() { Text = "ÎÊ", Left = 210, Width = 100, Top = 60, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }

        private void FloodFill(Bitmap bmp, Point pt, Color targetColor, Color replacementColor)
        {
            if (targetColor.ToArgb() == replacementColor.ToArgb()) return;

            Queue<Point> pixels = new Queue<Point>();
            pixels.Enqueue(pt);

            int width = bmp.Width;
            int height = bmp.Height;
            int targetArgb = targetColor.ToArgb();

            while (pixels.Count > 0)
            {
                Point a = pixels.Dequeue();

                if (a.X < 0 || a.X >= width || a.Y < 0 || a.Y >= height) continue;

                if (bmp.GetPixel(a.X, a.Y).ToArgb() == targetArgb)
                {
                    bmp.SetPixel(a.X, a.Y, replacementColor);

                    pixels.Enqueue(new Point(a.X - 1, a.Y));
                    pixels.Enqueue(new Point(a.X + 1, a.Y));
                    pixels.Enqueue(new Point(a.X, a.Y - 1));
                    pixels.Enqueue(new Point(a.X, a.Y + 1));
                }
            }
        }

        private bool ColorsMatch(Color c1, Color c2, int tolerance)
        {
            int totalDiff = Math.Abs(c1.R - c2.R) + Math.Abs(c1.G - c2.G) + Math.Abs(c1.B - c2.B);
            return totalDiff <= (tolerance * 3);
        }

        private void button_pen_Click(object sender, EventArgs e) => _currentToolIndex = 1;
        private void button_eraser_Click(object sender, EventArgs e) => _currentToolIndex = 2;
        private void button_ellipse_Click(object sender, EventArgs e) => _currentToolIndex = 3;
        private void button_rct_Click(object sender, EventArgs e) => _currentToolIndex = 4;
        private void button_line_Click(object sender, EventArgs e) => _currentToolIndex = 5;
        private void button_trg_Click(object sender, EventArgs e) => _currentToolIndex = 6;

        private void picture_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;
            _isDrawing = false;

            Point canvasPoint = GetAdjustedPoint(e.Location);
            Shape finalShape = null;

            if (_currentToolIndex == 1 || _currentToolIndex == 2)
            {
                finalShape = _currentFreehandShape;
                _currentFreehandShape = null;
            }
            else
            {
                finalShape = ShapeFactory.CreateShape(_currentToolIndex, _startPoint, canvasPoint, _currentColor, _currentThickness);
            }

            if (finalShape != null)
            {
                string actionName = GetToolName(_currentToolIndex);

                var command = new DrawCommand(finalShape, _mainBitmap, actionName);
                _historyManager.ExecuteCommand(command, _graphics);

                RefreshHistoryList();
                picture.Invalidate();
            }
        }

        // ЗАРЕФАКТОРИНИЙ МЕТОД: Позбавлений від роздутості, делегує завдання конкретним інструментам
        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            Point canvasPoint = GetAdjustedPoint(e.Location);

            if (_currentToolIndex == 7)
            {
                ExecuteTextTool(canvasPoint);
                return;
            }

            if (_currentToolIndex == 8)
            {
                ExecuteFloodFillTool(canvasPoint);
                return;
            }

            StartFreehandOrShapeDrawing(canvasPoint);
        }

        // ВИТЯГНУТИЙ МЕТОД: Логіка обробки інструменту "Текст"
        private void ExecuteTextTool(Point canvasPoint)
        {
            string enteredText = ShowTextInputDialog();
            if (!string.IsNullOrEmpty(enteredText))
            {
                Font currentFont = GetCurrentFont();
                Shape textShape = new TextShape(canvasPoint, enteredText, currentFont, _currentColor);

                var command = new DrawCommand(textShape, _mainBitmap, "Òåêñò");
                _historyManager.ExecuteCommand(command, _graphics);

                RefreshHistoryList();
                picture.Invalidate();
            }
            _isDrawing = false;
        }

        // ВИТЯГНУТИЙ МЕТОД: Логіка обробки інструменту "Заливка"
        private void ExecuteFloodFillTool(Point canvasPoint)
        {
            if (canvasPoint.X >= 0 && canvasPoint.X < _mainBitmap.Width && canvasPoint.Y >= 0 && canvasPoint.Y < _mainBitmap.Height)
            {
                Color targetColor = _mainBitmap.GetPixel(canvasPoint.X, canvasPoint.Y);

                FloodFill(_mainBitmap, canvasPoint, targetColor, _currentColor);

                Bitmap snapshot = new Bitmap(_mainBitmap);
                var command = new DrawCommand(new ImageShape(new Point(0, 0), snapshot), _mainBitmap, "Çàëèâêà");
                _historyManager.ExecuteCommand(command, _graphics);

                RefreshHistoryList();
                picture.Invalidate();
            }
            _isDrawing = false;
        }

        // ВИТЯГНУТИЙ МЕТОД: Ініціалізація малювання звичайних фігур або пензля/гумки
        private void StartFreehandOrShapeDrawing(Point canvasPoint)
        {
            _isDrawing = true;
            _startPoint = canvasPoint;

            if (_currentToolIndex == 1 || _currentToolIndex == 2)
            {
                _currentFreehandShape = ShapeFactory.CreateShape(_currentToolIndex, _startPoint, canvasPoint, _currentColor, _currentThickness);
            }
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            Point canvasPoint = GetAdjustedPoint(e.Location);

            if (_tempBitmap != null) _tempBitmap.Dispose();
            _tempBitmap = new Bitmap(_mainBitmap);

            using (Graphics g = Graphics.FromImage(_tempBitmap))
            {
                var shape = ShapeFactory.CreateShape(_currentToolIndex, _startPoint, canvasPoint, _currentColor, _currentThickness);

                if (_currentToolIndex == 1 || _currentToolIndex == 2)
                {
                    if (_currentFreehandShape is PenShape pen) pen.AddPoint(canvasPoint);
                    else if (_currentFreehandShape is EraserTool eraser) eraser.AddPoint(canvasPoint);
                    _currentFreehandShape?.Draw(g);
                }
                else
                {
                    shape?.Draw(g);
                }
            }

            picture.Invalidate();
        }

        private void color_picker_MouseDown(object sender, MouseEventArgs e)
        {
            if (color_picker.Image == null) return;

            try
            {
                using (Bitmap bmp = new Bitmap(color_picker.Width, color_picker.Height))
                {
                    color_picker.DrawToBitmap(bmp, new Rectangle(0, 0, color_picker.Width, color_picker.Height));

                    if (e.X >= 0 && e.X < bmp.Width && e.Y >= 0 && e.Y < bmp.Height)
                    {
                        Color pickedColor = bmp.GetPixel(e.X, e.Y);
                        UpdateDrawingColor(pickedColor);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ïîìèëêà âèáîðó êîëüîðó: {ex.Message}", "Ïîìèëêà",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _currentThickness = trackBar1.Value;
        }

        private void button_b_Click(object sender, EventArgs e)
        {
            _isBold = !_isBold;
            button_b.BackColor = _isBold ? Color.LightGray : SystemColors.Control;
        }

        private void button_i_Click(object sender, EventArgs e)
        {
            _isItalic = !_isItalic;
            button_i.BackColor = _isItalic ? Color.LightGray : SystemColors.Control;
        }

        private void button_u_Click(object sender, EventArgs e)
        {
            _isUnderline = !_isUnderline;
            button_u.BackColor = _isUnderline ? Color.LightGray : SystemColors.Control;
        }

        private void button_text_Click(object sender, EventArgs e)
        {
            _currentToolIndex = 7;
            panelTextOptions.Visible = !panelTextOptions.Visible;
        }

        private void button_colors_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = _currentColor;
                colorDialog.FullOpen = true;

                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    UpdateDrawingColor(colorDialog.Color);
                }
            }
        }

        private void button_fill_Click(object sender, EventArgs e) => _currentToolIndex = 8;

        private void button_add_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Title = "Îáåð³òü êàðòèíêó";
                openFileDialog.Filter = "Çîáðàæåííÿ (*.png;*.jpg;*.jpeg;*.bmp)|*.png;*.jpg;*.jpeg;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        using (Image loadedImage = Image.FromFile(openFileDialog.FileName))
                        {
                            _graphics.DrawImage(loadedImage, 0, 0, picture.Width, picture.Height);
                            Bitmap currentSate = new Bitmap(_mainBitmap);
                            var command = new DrawCommand(new ImageShape(new Point(0, 0), currentSate), _mainBitmap);
                            _historyManager.ExecuteCommand(command, _graphics);

                            picture.Image = _mainBitmap;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ïîìèëêà: {ex.Message}");
                    }
                }
            }
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "JSON Project|*.json|PNG Image|*.png|JPEG Image|*.jpg";
                saveFileDialog.Title = "Çáåðåãòè ðîáîòó";
                saveFileDialog.FileName = _projectName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = saveFileDialog.FileName;

                    if (filePath.EndsWith(".json"))
                    {
                        SaveProject(filePath);
                        AddToHistory(filePath);
                    }
                    else
                    {
                        _mainBitmap.Save(filePath);
                    }

                    MessageBox.Show("Çáåðåæåíî óñï³øíî!");
                }
            }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Âè âïåâíåí³, ùî õî÷åòå î÷èñòèòè ïîëîòíî òà ³ñòîð³þ ä³é?", "Ïîâíà î÷чиñòêà",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                _graphics.Clear(Color.White);
                _historyManager.ClearHistory();
                picture.Image = _mainBitmap;
                RefreshHistoryList();
            }
        }

        private void button_undo_Click(object sender, EventArgs e)
        {
            _historyManager.Undo();
            picture.Invalidate();
            RefreshHistoryList();
        }

        private void button_redo_Click(object sender, EventArgs e)
        {
            _historyManager.Redo(_graphics);
            picture.Invalidate();
            RefreshHistoryList();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Z))
            {
                button_undo_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.Y))
            {
                button_redo_Click(null, null);
                return true;
            }
            if (keyData == (Keys.Control | Keys.S))
            {
                button_save_Click(null, null);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void RefreshHistoryList()
        {
            listBoxHistory.Items.Clear();
            var names = _historyManager.GetHistoryNames();

            foreach (var name in names)
            {
                listBoxHistory.Items.Add(name);
            }
        }

        private string GetToolName(int index)
        {
            return index switch
            {
                1 => "Îë³âåöü",
                2 => "Ãóìêà",
                3 => "Åë³ïñ",
                4 => "Ïðÿìîêóòíèê",
                5 => "Ë³í³ÿ",
                6 => "Òðèêóòíèê",
                7 => "Òåêñò",
                8 => "Çàëèâêà",
                _ => "Ìàëþâàííÿ"
            };
        }

        private void button_plus_Click(object sender, EventArgs e)
        {
            if (trackBarZoom.Value + 2 <= trackBarZoom.Maximum)
            {
                UpdateZoom((trackBarZoom.Value + 2) / 10.0f);
            }
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            if (trackBarZoom.Value - 2 >= trackBarZoom.Minimum)
            {
                UpdateZoom((trackBarZoom.Value - 2) / 10.0f);
            }
        }

        private Point GetAdjustedPoint(Point mousePoint)
        {
            return new Point(
                (int)((mousePoint.X / _zoomFactor) - _offset.X),
                (int)((mousePoint.Y / _zoomFactor) - _offset.Y)
            );
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.NearestNeighbor;

            using (var attributes = new System.Drawing.Imaging.ImageAttributes())
            {
                attributes.SetWrapMode(System.Drawing.Drawing2D.WrapMode.Clamp);
                g.ScaleTransform(_zoomFactor, _zoomFactor);

                if (_mainBitmap != null)
                {
                    Bitmap bitmapToDraw = _isDrawing ? _tempBitmap : _mainBitmap;

                    if (bitmapToDraw != null)
                    {
                        g.DrawImage(
                            bitmapToDraw,
                            new Rectangle(0, 0, bitmapToDraw.Width, bitmapToDraw.Height),
                            0, 0, bitmapToDraw.Width, bitmapToDraw.Height,
                            GraphicsUnit.Pixel,
                            attributes
                        );
                    }
                }
            }
        }

        private void UpdateZoom(float newFactor)
        {
            _zoomFactor = newFactor;

            int trackBarValue = (int)(_zoomFactor * 10);
            if (trackBarValue >= trackBarZoom.Minimum && trackBarValue <= trackBarZoom.Maximum)
            {
                trackBarZoom.Value = trackBarValue;
            }

            labelZoomPercent.Text = $"{(int)(_zoomFactor * 100)}%";
            picture.Invalidate();
        }

        private void trackBarZoom_Scroll(object sender, EventArgs e)
        {
            UpdateZoom(trackBarZoom.Value / 10.0f);
        }

        private void button_returntomenu_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                    "Âè âïåâíåí³, ùî õî÷åòå ïîâåðíóòèñÿ â ãîëîâíå ìåíþ? Íåçáåðåæåí³ çì³íè ìîæóòü áóòї âòðà÷åí³.",
                    "Âèõ³ä ó ìåíþ",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void AddToHistory(string filePath)
        {
            try
            {
                string historyPath = Path.Combine(Application.StartupPath, "recent_files.txt");
                List<string> lines = File.Exists(historyPath)
                    ? File.ReadAllLines(historyPath).ToList()
                    : new List<string>();

                if (lines.Contains(filePath)) lines.Remove(filePath);
                lines.Insert(0, filePath);

                File.WriteAllLines(historyPath, lines.Take(10));
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ïîìèëêà çàïèñó ³ñòоð³¿: " + ex.Message);
            }
        }
    }
}
