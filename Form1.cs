namespace paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
