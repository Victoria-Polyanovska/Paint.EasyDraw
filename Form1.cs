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
    }
}
    
