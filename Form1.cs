using paint.ToolsLibrary;

namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

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
        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void pic_Click(object sender, EventArgs e)
        {

        }

        private void btn_redo_Click(object sender, EventArgs e)
        {

        }
        public void LoadImage(string path)
        {
            this.BackgroundImage = Image.FromFile(path);
            this.BackgroundImageLayout = ImageLayout.Zoom;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            StartForm startForm = new StartForm();
            startForm.Show();
            this.Close();
        }
        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            p.Width = trackBar1.Value;
            erase.Width = trackBar1.Value;
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

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = e.X - cX; // Ширина
            sY = e.Y - cY; // Висота 

            ToolsLibrary.Shape shape = null;

            if (index == 3)
            {
                shape = new EllipseShape(
                    new Rectangle(Math.Min(cX, cX + sX), Math.Min(cY, cY + sY), Math.Abs(sX), Math.Abs(sY)), p.Color, p.Width);
            }
            else if (index == 4)
            {
                shape = new RectangleShape(
                    new Point(cX, cY),
                    new Point(cX + sX, cY + sY), p.Color, p.Width);
            }
            else if (index == 5)
            {
                shape = new LineShape(
                    new Point(cX, cY),
                    new Point(e.X, e.Y), p.Color, p.Width);
            }
            else if (index == 6)
            {
                shape = new TriangleShape(
                    new Point(cX, cY),
                    new Point(e.X, e.Y), p.Color, p.Width);
            }

            if (shape != null)
            {
                using (Graphics gBm = Graphics.FromImage(bm))
                {
                    shape.Draw(gBm);
                }
                pic.Image = bm;
                pic.Refresh();
            }
        }

        private void btn_pencil_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btn_ellips_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void btn_trg_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void btn_rect_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void pic_Paint(object sender, PaintEventArgs e)
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
                    Point[] trianglePoints = {
                    new Point(cX + sX / 2, cY),
                    new Point(cX, cY + sY),
                    new Point(cX + sX, cY + sY)
                 };
                    g.DrawPolygon(p, trianglePoints);
                }
            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            pic.Image = bm;
            index = 0;
            pic.Refresh();
        }

        private void btn_color_Click(object sender, EventArgs e)
        {

            cd.ShowDialog();
            new_color = cd.Color;
            pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }
        static Point set_point(PictureBox pb, Point pt)
        {
            float pX = 1f * pb.Image.Width / pb.Width;
            float pY = 1f * pb.Image.Height / pb.Height;
            return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        }

        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = set_point(color_picker, e.Location);
            pic_color.BackColor = ((Bitmap)color_picker.Image).GetPixel(point.X, point.Y);
            new_color = pic_color.BackColor;
            p.Color = pic_color.BackColor;
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
            if (old_color == new_clr) return; // перевірка перед фарбуванням

            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));

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

        private void btn_fill_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        private void pic_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (index == 7)
            {
                Point point = set_point(pic, e.Location);
                Fill(bm, point.X, point.Y, new_color);
                pic.Image = bm;
                pic.Refresh();
            }
        }
    }
    }

    
