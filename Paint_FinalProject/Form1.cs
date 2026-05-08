using Paint_FinalProject.Commands;
using Paint_FinalProject.ToolsLibrary;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Paint_FinalProject
{
    public partial class Form1 : Form
    {
        private Bitmap _mainBitmap;
        private Bitmap _tempBitmap;
        private Graphics _graphics;

        private int _currentToolIndex = 1;
        private Color _currentColor = Color.Black;
        private float _currentThickness = 2f;

        private Point _startPoint;
        private bool _isDrawing = false;
        private Shape _currentFreehandShape;

        private bool _isBold = false;
        private bool _isItalic = false;
        private bool _isUnderline = false;

        private HistoryManager _historyManager;
        public Form1()
        {
            InitializeComponent();
            SetupCanvas();
        }
        private void SetupCanvas()
        {
            panelTextOptions.Visible = false;
            _mainBitmap = new Bitmap(picture.Width, picture.Height);
            _graphics = Graphics.FromImage(_mainBitmap);
            _graphics.Clear(Color.White);

            picture.Image = _mainBitmap;

            _historyManager = new HistoryManager(_mainBitmap);

            if (color_picker != null && color_picker.Image != null)
            {
                if (!(color_picker.Image is Bitmap))
                {
                    color_picker.Image = new Bitmap(color_picker.Image);
                }
            }
            foreach (FontFamily font in FontFamily.Families)
            {
                comboBoxFonts.Items.Add(font.Name);
            }

            if (comboBoxFonts.Items.Contains("Arial"))
            {
                comboBoxFonts.SelectedItem = "Arial";
            }
            else if (comboBoxFonts.Items.Count > 0)
            {
                comboBoxFonts.SelectedIndex = 0;
            }

            UpdateDrawingColor(Color.Black);
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
                Text = "Введіть текст для малювання",
                StartPosition = FormStartPosition.CenterParent,
                MaximizeBox = false
            };

            TextBox textBox = new TextBox() { Left = 20, Top = 20, Width = 290 };

            Button confirmation = new Button() { Text = "ОК", Left = 210, Width = 100, Top = 60, DialogResult = DialogResult.OK };

            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
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

            Shape finalShape = null;

            if (_currentToolIndex == 1 || _currentToolIndex == 2)
            {
                finalShape = _currentFreehandShape;
                _currentFreehandShape = null;
            }
            else
            {
                finalShape = ShapeFactory.CreateShape(_currentToolIndex, _startPoint, e.Location, _currentColor, _currentThickness);
            }

            if (finalShape != null)
            {
                var command = new DrawCommand(finalShape, _mainBitmap);
                _historyManager.ExecuteCommand(command, _graphics);
            }

            picture.Image = _mainBitmap;
        }

        private void picture_MouseDown(object sender, MouseEventArgs e)
        {
            if (_currentToolIndex == 7)
            {
                string enteredText = ShowTextInputDialog();

                if (!string.IsNullOrEmpty(enteredText))
                {
                    Font currentFont = GetCurrentFont();
                    Shape textShape = new TextShape(e.Location, enteredText, currentFont, _currentColor);

                    var command = new DrawCommand(textShape, _mainBitmap);
                    _historyManager.ExecuteCommand(command, _graphics);

                    picture.Image = _mainBitmap;
                }

                _isDrawing = false;

                return;
            }
            _isDrawing = true;
            _startPoint = e.Location;
            if (_currentToolIndex == 1 || _currentToolIndex == 2)
            {
                _currentFreehandShape = ShapeFactory.CreateShape(_currentToolIndex, _startPoint, e.Location, _currentColor, _currentThickness);
            }
        }

        private void picture_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_isDrawing) return;

            if (_tempBitmap != null) _tempBitmap.Dispose();
            _tempBitmap = new Bitmap(_mainBitmap);

            using (Graphics g = Graphics.FromImage(_tempBitmap))
            {
                if (_currentToolIndex == 1 || _currentToolIndex == 2)
                {
                    if (_currentFreehandShape is PenShape pen) pen.AddPoint(e.Location);
                    else if (_currentFreehandShape is EraserTool eraser) eraser.AddPoint(e.Location);

                    _currentFreehandShape?.Draw(g);
                }
                else
                {
                    var shape = ShapeFactory.CreateShape(_currentToolIndex, _startPoint, e.Location, _currentColor, _currentThickness);
                    shape?.Draw(g);
                }
            }
            picture.Image = _tempBitmap;
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
                MessageBox.Show($"Помилка вибору кольору: {ex.Message}", "Помилка",
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
    }
}
