using paint.ToolsLibrary;
using System.Drawing;
using Microsoft.VisualBasic;
using paint;

namespace paint
{
    // Enum замість магічних чисел
    public enum DrawingTool
    {
        None = 0,
        Pencil = 1,
        Eraser = 2,
        Ellipse = 3,
        Rectangle = 4,
        Line = 5,
        Triangle = 6,
        Fill = 7,
        Text = 8
    }

    public partial class Form1 : Form
    {
        // Константи замість магічних чисел
        private const int FORM_WIDTH = 1330;
        private const int FORM_HEIGHT = 750;
        private const int DEFAULT_PEN_WIDTH = 5;
        private const int MIN_FONT_SIZE = 8;
        private const int MAX_FONT_SIZE = 72;
        private const int DEFAULT_FONT_SIZE = 12;

        private Bitmap bm;
        private Graphics g;
        private bool isDrawing = false;
        private Point previousPoint, startPoint;
        private Pen currentPen;
        private readonly Pen erasePen;
        private DrawingTool currentTool = DrawingTool.None;
        
        private List<Shape> shapes = new List<Shape>();
        
        private ColorDialog colorDialog = new ColorDialog();
        private Color currentColor;
        
        private bool isTextModeActive = false;
        private Font currentFont;
        private FontStyle currentFontStyle = FontStyle.Regular;

        public Form1()
        {
            InitializeComponent();
            InitializeTextOptionsPanel();
            InitializeDrawingSurface();
            InitializePenSettings();
        }

        private void InitializeDrawingSurface()
        {
            this.Width = FORM_WIDTH;
            this.Height = FORM_HEIGHT;
            
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        private void InitializePenSettings()
        {
            currentPen = new Pen(Color.Black, DEFAULT_PEN_WIDTH);
            trackBar1.Value = DEFAULT_PEN_WIDTH;
            UpdatePenWidth(DEFAULT_PEN_WIDTH);
        }

        private void UpdatePenWidth(int width)
        {
            currentPen.Width = width;
        }

        private readonly Pen erasePen = new Pen(Color.White, DEFAULT_PEN_WIDTH);

        private void InitializeTextOptionsPanel()
        {
            LoadFontsIntoComboBox();
            SetupFontSizeComboBox();
            currentFont = new Font("Arial", DEFAULT_FONT_SIZE);
        }

        private void LoadFontsIntoComboBox()
        {
            fontComboBoxInPanel.Items.Clear();
            foreach (FontFamily font in FontFamily.Families)
            {
                fontComboBoxInPanel.Items.Add(font.Name);
            }
            fontComboBoxInPanel.SelectedItem = "Arial";
            fontComboBoxInPanel.SelectedIndexChanged += OnFontChanged;
        }

        private void SetupFontSizeComboBox()
        {
            fontSizeComboBoxInPanel.Minimum = MIN_FONT_SIZE;
            fontSizeComboBoxInPanel.Maximum = MAX_FONT_SIZE;
            fontSizeComboBoxInPanel.Value = DEFAULT_FONT_SIZE;
            fontSizeComboBoxInPanel.ValueChanged += OnFontSizeChanged;
        }

        private void OnFontChanged(object sender, EventArgs e)
        {
            if (fontComboBoxInPanel.SelectedItem != null)
            {
                currentFont = new Font(
                    fontComboBoxInPanel.SelectedItem.ToString(),
                    currentFont.Size, 
                    currentFontStyle);
            }
        }

        private void OnFontSizeChanged(object sender, EventArgs e)
        {
            currentFont = new Font(
                currentFont.FontFamily,
                (float)fontSizeComboBoxInPanel.Value,
                currentFontStyle);
        }

        private void UpdateCurrentFont()
        {
            if (fontComboBoxInPanel.SelectedItem != null)
            {
                string fontName = fontComboBoxInPanel.SelectedItem.ToString();
                float fontSize = (float)fontSizeComboBoxInPanel.Value;
                currentFont = new Font(fontName, fontSize, currentFontStyle);
            }
        }

        private void ToggleFontStyle(FontStyle style)
        {
            currentFontStyle ^= style;
            UpdateCurrentFont();
        }

        private static Point ScalePointToImage(PictureBox pictureBox, Point point)
        {
            float scaleX = 1f * pictureBox.Image.Width / pictureBox.Width;
            float scaleY = 1f * pictureBox.Image.Height / pictureBox.Height;
            return new Point((int)(point.X * scaleX), (int)(point.Y * scaleY));
        }

        #region Drawing Methods
        private void DrawWithCurrentTool(Point currentPoint)
        {
            if (currentTool == DrawingTool.Pencil)
            {
                g.DrawLine(currentPen, previousPoint, currentPoint);
                previousPoint = currentPoint;
            }
            else if (currentTool == DrawingTool.Eraser)
            {
                g.DrawLine(erasePen, previousPoint, currentPoint);
                previousPoint = currentPoint;
            }
        }

      private void DrawShapePreview(PaintEventArgs e)
        {
            if (!isDrawing) return;
            
            Graphics graphics = e.Graphics;
            int width = previousPoint.X - startPoint.X;
            int height = previousPoint.Y - startPoint.Y;
            
            switch (currentTool)
            {
                case DrawingTool.Ellipse:
                    graphics.DrawEllipse(currentPen, startPoint.X, startPoint.Y, width, height);
                    break;
                case DrawingTool.Rectangle:
                    graphics.DrawRectangle(currentPen, startPoint.X, startPoint.Y, width, height);
                    break;
                case DrawingTool.Line:
                    graphics.DrawLine(currentPen, startPoint.X, startPoint.Y, previousPoint.X, previousPoint.Y);
                    break;
                case DrawingTool.Triangle:
                    DrawTrianglePreview(graphics, width, height);
                    break;
            }
        }

        private void DrawTrianglePreview(Graphics graphics, int width, int height)
        {
            Point[] trianglePoints = {
                new Point(startPoint.X + width / 2, startPoint.Y),
                new Point(startPoint.X, startPoint.Y + height),
                new Point(startPoint.X + width, startPoint.Y + height)
            };
            graphics.DrawPolygon(currentPen, trianglePoints);
        }

        private Shape CreateShape(Point start, Point end)
        {
            int width = end.X - start.X;
            int height = end.Y - start.Y;
            
            return currentTool switch
            {
                DrawingTool.Ellipse => CreateEllipseShape(start, end, width, height),
                DrawingTool.Rectangle => new RectangleShape(start, end, currentPen.Color, (int)currentPen.Width),
                DrawingTool.Line => new LineShape(start, end, currentPen.Color, (int)currentPen.Width),
                DrawingTool.Triangle => new TriangleShape(start, end, currentPen.Color, (int)currentPen.Width),
                _ => null
            };
        }

        private EllipseShape CreateEllipseShape(Point start, Point end, int width, int height)
        {
            Rectangle rect = new Rectangle(
                Math.Min(start.X, end.X),
                Math.Min(start.Y, end.Y),
                Math.Abs(width),
                Math.Abs(height)
            );
            return new EllipseShape(rect, currentPen.Color, (int)currentPen.Width);
        }

        private void FinalizeShape(Shape shape)
        {
            if (shape == null) return;
            
            using (Graphics graphics = Graphics.FromImage(bm))
            {
                graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                shape.Draw(graphics);
            }
            pic.Image = bm;
        }
        #endregion

        #region Flood Fill Implementation
        public void FloodFill(Bitmap bitmap, int x, int y, Color newColor)
        {
            Color oldColor = bitmap.GetPixel(x, y);
            if (oldColor == newColor) return;

            Stack<Point> pixels = new Stack<Point>();
            pixels.Push(new Point(x, y));

            while (pixels.Count > 0)
            {
                Point point = pixels.Pop();
                
                if (IsPointInsideBounds(bitmap, point))
                {
                    Color currentColor = bitmap.GetPixel(point.X, point.Y);
                    
                    if (currentColor == oldColor)
                    {
                        bitmap.SetPixel(point.X, point.Y, newColor);
                        
                        // Додаємо сусідні пікселі
                        pixels.Push(new Point(point.X - 1, point.Y));
                        pixels.Push(new Point(point.X + 1, point.Y));
                        pixels.Push(new Point(point.X, point.Y - 1));
                        pixels.Push(new Point(point.X, point.Y + 1));
                    }
                }
            }
        }

        private bool IsPointInsideBounds(Bitmap bitmap, Point point)
        {
            return point.X > 0 && point.Y > 0 && 
                   point.X < bitmap.Width - 1 && 
                   point.Y < bitmap.Height - 1;
        }
        #endregion

        #region Image Loading
        private void LoadImageFromFile(string filePath)
        {
            string[] allowedExtensions = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
            string extension = Path.GetExtension(filePath).ToLower();

            if (!allowedExtensions.Contains(extension))
            {
                MessageBox.Show("Можна додавати тільки зображення!", "Помилка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (Image image = Image.FromFile(filePath))
            {
                bm = new Bitmap(pic.Width, pic.Height);
                
                using (Graphics graphics = Graphics.FromImage(bm))
                {
                    graphics.Clear(Color.White);
                    graphics.DrawImage(image, 0, 0, pic.Width, pic.Height);
                }
                
                g = Graphics.FromImage(bm);
                pic.Image = bm;
            }
        }

        public void LoadImage(string path)
        {
            this.BackgroundImage = Image.FromFile(path);
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }
        #endregion

        #region Event Handlers
      private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
            startPoint = e.Location;
            previousPoint = e.Location;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDrawing)
            {
                DrawWithCurrentTool(e.Location);
                previousPoint = e.Location; // Запам'ятовуємо поточну позицію миші
            }
            pic.Refresh();
        }
        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (currentTool == DrawingTool.Fill)
            {
                Point scaledPoint = ScalePointToImage(pic, e.Location);
                FloodFill(bm, scaledPoint.X, scaledPoint.Y, currentColor);
                pic.Image = bm;
            }
            else if (currentTool == DrawingTool.Text && isTextModeActive)
            {
                AddTextToImage(e.Location);
            }
        }

        private void AddTextToImage(Point location)
        {
            string input = Interaction.InputBox("Введіть текст:", "Додавання тексту", "Текст");
            
            if (!string.IsNullOrEmpty(input))
            {
                Point scaledPoint = ScalePointToImage(pic, location);
                TextShape textShape = new TextShape(input, scaledPoint, currentFont, currentPen.Color);
                shapes.Add(textShape);
                pic.Invalidate();
            }
        }

      private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            isDrawing = false;
            
            Point startPointScaled = ScalePointToImage(pic, startPoint);
            Point endPointScaled = ScalePointToImage(pic, e.Location);
            
            try
            {
                Shape shape = CreateShape(startPointScaled, endPointScaled);
                FinalizeShape(shape);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка малювання фігури: " + ex.Message);
            }
            
            pic.Refresh();
        }

        private void pic_Paint_1(object sender, PaintEventArgs e)
        {
            DrawShapePreview(e);
            
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            if (color_picker.Image == null) return;
            
            Point point = ScalePointToImage(color_picker, e.Location);
            Bitmap bitmap = (Bitmap)color_picker.Image;
            
            if (IsPointInsideBitmap(bitmap, point))
            {
                currentColor = bitmap.GetPixel(point.X, point.Y);
                currentPen.Color = currentColor;
                pic_color.BackColor = currentColor;
            }
        }

        private bool IsPointInsideBitmap(Bitmap bitmap, Point point)
        {
            return point.X >= 0 && point.Y >= 0 && 
                   point.X < bitmap.Width && 
                   point.Y < bitmap.Height;
        }

        private void trackBar1_ValueChanged_2(object sender, EventArgs e)
        {
            int newWidth = trackBar1.Value;
            currentPen.Width = newWidth;
            erasePen.Width = newWidth;
        }

        private void btn_color_Click_1(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                currentColor = colorDialog.Color;
                currentPen.Color = currentColor;
                pic_color.BackColor = currentColor;
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            shapes.Clear();
            pic.Image = bm;
            currentTool = DrawingTool.None;
            pic.Refresh();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }

        private void btn_addpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Зображення (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Всі файли (*.*)|*.*",
                Title = "Виберіть зображення"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                LoadImageFromFile(openFileDialog.FileName);
            }
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            textOptionsPanel.Visible = !textOptionsPanel.Visible;
            
            if (currentTool == DrawingTool.Text)
            {
                currentTool = DrawingTool.None;
                btn_text.BackColor = SystemColors.GrayText;
                isTextModeActive = false;
            }
            else
            {
                currentTool = DrawingTool.Text;
                btn_text.BackColor = Color.DimGray;
                isTextModeActive = true;
            }
        }

        // Спрощені методи для вибору інструментів
        private void SetDrawingTool(DrawingTool tool)
        {
            currentTool = tool;
        }

        private void btn_pencil_Click_1(object sender, EventArgs e) => SetDrawingTool(DrawingTool.Pencil);
        private void btn_eraser_Click_1(object sender, EventArgs e) => SetDrawingTool(DrawingTool.Eraser);
        private void btn_ellips_Click_1(object sender, EventArgs e) => SetDrawingTool(DrawingTool.Ellipse);
        private void btn_rect_Click_1(object sender, EventArgs e) => SetDrawingTool(DrawingTool.Rectangle);
        private void btn_line_Click_1(object sender, EventArgs e) => SetDrawingTool(DrawingTool.Line);
        private void btn_trg_Click_1(object sender, EventArgs e) => SetDrawingTool(DrawingTool.Triangle);
        private void btn_fill_Click_1(object sender, EventArgs e) => SetDrawingTool(DrawingTool.Fill);
        private void btn_redo_Click(object sender, EventArgs e) { } // Заглушка для Undo/Redo

        // Стилі тексту
        private void btn_b_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Bold);
        private void btn_i_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Italic);
        private void btn_u_Click(object sender, EventArgs e) => ToggleFontStyle(FontStyle.Underline);
        #endregion
    }
}
