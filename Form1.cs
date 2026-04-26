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
    }
}
