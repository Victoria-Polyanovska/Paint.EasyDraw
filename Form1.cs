using paint.ToolsLibrary;
using System.Drawing;
using Microsoft.VisualBasic;
using paint;


namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeTextOptionsPanel();

            this.Width = 1330;
            this.Height = 750;

            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;

            trackBar1.Value = 5;
            erase.Width = trackBar1.Value;
        }
        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;
        Pen p = new Pen(Color.Black, 1);
        Pen erase = new Pen(Color.White, 10);
        int index; int x, y, sX, sY, cX, cY;

        private List<Shape> shapes = new List<Shape>();

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private bool drawingText = false;
        private Font currentFont = new Font("Arial", 12);
        private FontStyle currentFontStyle = FontStyle.Regular;

        private void btn_redo_Click(object sender, EventArgs e)
        {

        }
        public void LoadImage(string path)
        {
            this.BackgroundImage = Image.FromFile(path);
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;

        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(erase, px, py);
                    py = px;
                }
                x = e.X;
                y = e.Y;
                sX = e.X - cX;
                sY = e.Y - cY;
            }
            pic.Refresh();
        }
        private void InitializeTextOptionsPanel()
        {
            fontComboBoxInPanel.Items.Clear();
            foreach (FontFamily font in FontFamily.Families)
            {
                fontComboBoxInPanel.Items.Add(font.Name);
            }
            fontComboBoxInPanel.SelectedItem = "Arial";
            fontComboBoxInPanel.SelectedIndexChanged += (s, e) =>
            {
                if
                (fontComboBoxInPanel.SelectedItem != null)
                {
                    currentFont = new Font(
                        fontComboBoxInPanel.SelectedItem.ToString(),
                        currentFont.Size, currentFontStyle);
                }
            };
            fontSizeComboBoxInPanel.Minimum = 8;
            fontSizeComboBoxInPanel.Maximum = 72;
            fontSizeComboBoxInPanel.Value = 12;
            fontSizeComboBoxInPanel.ValueChanged += (s, e) =>
            {
                currentFont = new Font(
                    currentFont.FontFamily,
                    (float)fontSizeComboBoxInPanel.Value,
                    currentFontStyle);
            };
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            if (color_picker.Image == null) return;
            Point point = set_point(color_picker, e.Location);
            Bitmap bmp = (Bitmap)color_picker.Image;
            if (point.X < 0 || point.Y < 0 || point.X >= bmp.Width || point.Y >= bmp.Height) return;
            Color picked = bmp.GetPixel(point.X, point.Y);
            new_color = picked;
            p.Color = picked;
            pic_color.BackColor = picked;
        }
        private void validate(Bitmap bm, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bm.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bm.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bm, int x, int y, Color new_clr)
        {
            Color old_color = bm.GetPixel(x, y);
            if (old_color == new_clr) return;

            Stack<Point> pixel = new Stack<Point>(); pixel.Push(new Point(x, y));
            while (pixel.Count > 0)
            {
                Point pt = pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bm.Width - 1 && pt.Y < bm.Height - 1)
                {
                    Color cx = bm.GetPixel(pt.X, pt.Y);
                    if (cx == old_color)
                    {
                        bm.SetPixel(pt.X, pt.Y, new_clr);
                        pixel.Push(new Point(pt.X - 1, pt.Y));
                        pixel.Push(new Point(pt.X + 1, pt.Y));
                        pixel.Push(new Point(pt.X, pt.Y - 1));
                        pixel.Push(new Point(pt.X, pt.Y + 1));
                    }
                }
            }
        }

        private void btn_addpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Зображення (*.jpg;*.jpeg;*.png;*.gif;*.bmp)|*.jpg;*.jpeg;*.png;*.gif;*.bmp",
                Title = "Виберіть зображення"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                string[] allowedExt = { ".jpg", ".jpeg", ".png", ".gif", ".bmp" };
                string ext = Path.GetExtension(filePath).ToLower();

                if (!allowedExt.Contains(ext))
                {
                    MessageBox.Show("Можна додавати тільки зображення!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                try
                {
                    using (Image tempImg = Image.FromFile(filePath))
                    {
                        bm = new Bitmap(pic.Width, pic.Height);

                        using (Graphics gr = Graphics.FromImage(bm))
                        {
                            gr.Clear(Color.White);
                            gr.DrawImage(tempImg, 0, 0, pic.Width, pic.Height);
                        }
                    }
                    g = Graphics.FromImage(bm);
                    g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                    pic.Image = bm;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося завантажити файл: {ex.Message}");
                }
            }
        }

        private void btn_text_Click(object sender, EventArgs e)
        {
            textOptionsPanel.Visible = !textOptionsPanel.Visible;
            if (index == 8)
            {
                index = 0;
                btn_text.BackColor = SystemColors.GrayText;
                drawingText = false;
            }
            else
            {
                index = 8;
                btn_text.BackColor = Color.DimGray;
                drawingText = true;
            }
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


        private void btn_b_Click(object sender, EventArgs e)
        {
            currentFontStyle ^= FontStyle.Bold;
            UpdateCurrentFont();
        }

        private void btn_i_Click(object sender, EventArgs e)
        {
            currentFontStyle ^= FontStyle.Italic;
            UpdateCurrentFont();
        }

        private void btn_u_Click(object sender, EventArgs e)
        {
            currentFontStyle ^= FontStyle.Underline;
            UpdateCurrentFont();
        }

        private void trackBar1_ValueChanged_2(object sender, EventArgs e)
        {
            p.Width = trackBar1.Value;
            erase.Width = trackBar1.Value;
        }

        private void btn_color_Click_1(object sender, EventArgs e)
        {
            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        private void btn_fill_Click_1(object sender, EventArgs e)
        {
            index = 7;
        }

        private void btn_ellips_Click_1(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_rect_Click_1(object sender, EventArgs e)
        {
            index = 4;
        }
        private void btn_line_Click_1(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btn_trg_Click_1(object sender, EventArgs e)
        {
            index = 6;
        }

        private void pic_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    g.DrawRectangle(p, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    g.DrawLine(p, cX, cY, x, y);
                }
                if (index == 6)
                {
                    Point[] trianglePoints = { new Point(cX + sX / 2, cY), new Point(cX, cY + sY), new Point(cX + sX, cY + sY) };
                    g.DrawPolygon(p, trianglePoints);
                }
            }
            foreach (var shape in shapes)
            {
                shape.Draw(e.Graphics);
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            shapes.Clear();
            pic.Image = bm;
            index = 0; pic.Refresh();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
                pic.Image = bm;
            }
            else if (index == 8 && drawingText)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox("Введіть текст:", "Додавання тексту", "Текст");
                if (!string.IsNullOrEmpty(input))
                {
                    Point point = set_point(pic, e.Location);
                    TextShape textShape = new TextShape(input, point, currentFont, p.Color);
                    shapes.Add(textShape); pic.Invalidate();
                }
            }
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            Point startPoint = set_point(pic, py);
            Point endPoint = set_point(pic, e.Location);

            int curSX = endPoint.X - startPoint.X;
            int curSY = endPoint.Y - startPoint.Y;

            Shape shape = null;

            if (index == 3) 
            {
                shape = new EllipseShape(new Rectangle(
                    Math.Min(startPoint.X, endPoint.X),
                    Math.Min(startPoint.Y, endPoint.Y),
                    Math.Abs(curSX),
                    Math.Abs(curSY)),
                    p.Color, p.Width);
            }
            else if (index == 4) 
            {
                shape = new RectangleShape(
                    new Point(Math.Min(startPoint.X, endPoint.X), Math.Min(startPoint.Y, endPoint.Y)),
                    new Point(Math.Max(startPoint.X, endPoint.X), Math.Max(startPoint.Y, endPoint.Y)),
                    p.Color, p.Width);
            }
            else if (index == 5) 
            {
                shape = new LineShape(startPoint, endPoint, p.Color, p.Width);
            }
            else if (index == 6) 
            {
                shape = new TriangleShape(startPoint, endPoint, p.Color, p.Width);
            }

            if (shape != null)
            {
                using (Graphics gBm = Graphics.FromImage(bm))
                {
                    gBm.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    shape.Draw(gBm);
                }
                pic.Image = bm;
                pic.Refresh();
            }
        }

        private void btn_pencil_Click_1(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click_1(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Зображення PNG (*.png)|*.png|Зображення JPEG (*.jpg)|*.jpg|Бітмап (*.bmp)|*.bmp",
                Title = "Зберегти малюнок",
                FileName = "малюнок" 
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string extension = Path.GetExtension(saveFileDialog.FileName).ToLower();

                    System.Drawing.Imaging.ImageFormat format = System.Drawing.Imaging.ImageFormat.Png;

                    switch (extension)
                    {
                        case ".jpg":
                        case ".jpeg":
                            format = System.Drawing.Imaging.ImageFormat.Jpeg;
                            break;
                        case ".bmp":
                            format = System.Drawing.Imaging.ImageFormat.Bmp;
                            break;
                    }

                    bm.Save(saveFileDialog.FileName, format);

                    MessageBox.Show("Зображення успішно збережено!", "Успіх",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при збереженні: {ex.Message}", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

    
