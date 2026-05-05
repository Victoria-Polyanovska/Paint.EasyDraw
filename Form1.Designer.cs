namespace paint
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            btn_addpic = new Button();
            btn_layers = new Button();
            btn_trg = new Button();
            pic_color = new Button();
            color_picker = new PictureBox();
            btn_clear = new Button();
            btn_line = new Button();
            btn_save = new Button();
            btn_color = new Button();
            btn_rect = new Button();
            btn_fill = new Button();
            btn_ellips = new Button();
            btn_text = new Button();
            btn_pencil = new Button();
            btn_eraser = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            btn_back = new Button();
            btn_zoomout = new Button();
            btn_zoomin = new Button();
            btn_redo = new Button();
            btn_undo = new Button();
            pic = new PictureBox();
            trackBar1 = new TrackBar();
            textOptionsPanel = new Panel();
            btn_u = new Button();
            btn_i = new Button();
            btn_b = new Button();
            fontSizeComboBoxInPanel = new NumericUpDown();
            fontComboBoxInPanel = new ComboBox();
            layersPanel = new Panel();
            btn_down = new Button();
            listBox1 = new ListBox();
            btn_up = new Button();
            btn_vis = new Button();
            btn_add = new Button();
            btn_del = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            textOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fontSizeComboBoxInPanel).BeginInit();
            layersPanel.SuspendLayout();
            SuspendLayout();

            // panel1
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1308, 111);
            panel1.TabIndex = 0;

            // panel3
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(btn_addpic);
            panel3.Controls.Add(btn_trg);
            panel3.Controls.Add(pic_color);
            panel3.Controls.Add(color_picker);
            panel3.Controls.Add(btn_clear);
            panel3.Controls.Add(btn_save);
            panel3.Controls.Add(btn_rect);
            panel3.Controls.Add(btn_fill);
            panel3.Controls.Add(btn_ellips);
            panel3.Controls.Add(btn_text);
            panel3.Controls.Add(btn_pencil);
            panel3.Controls.Add(btn_eraser);
            panel3.Location = new Point(3, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(1424, 90);
            panel3.TabIndex = 3;

            // pic
            pic.BackColor = Color.White;
            pic.Location = new Point(6, 117);
            pic.Name = "pic";
            pic.Size = new Size(877, 493);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint_1; // Виправлено!
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;

            // trackBar1
            trackBar1.Location = new Point(1008, 117);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(293, 69);
            trackBar1.TabIndex = 3;
            trackBar1.ValueChanged += trackBar1_ValueChanged_2; // Виправлено!

            // btn_trg
            btn_trg.Click += btn_trg_Click_1; // Виправлено!

            // Решта налаштувань (додайте за потреби)
            // ...

            ResumeLayout(false);
            PerformLayout();
        }

#endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pic;
        private Button btn_color;
        private Button pic_color;
        private Button btn_ellips;
        private Button btn_eraser;
        private Button btn_pencil;
        private Button btn_fill;
        private Button btn_line;
        private Button btn_rect;
        private Button btn_text;
        private Panel panel3;
        private Button btn_clear;
        private Button btn_save;
        private PictureBox color_picker;
        private TrackBar trackBar1;
        private Panel panel4;
        private Button btn_redo;
        private Button btn_undo;
        private Button btn_zoomin;
        private Button btn_zoomout;
        private Button btn_trg;
        private Button btn_back;
        private Panel textOptionsPanel;
        private ComboBox fontComboBoxInPanel;
        private Button btn_b;
        private NumericUpDown fontSizeComboBoxInPanel;
        private Button btn_u;
        private Button btn_i;
        private Button btn_vis;
        private Button btn_down;
        private Button btn_up;
        private Button btn_del;
        private Button btn_add;
        private ListBox listBox1;
        private Panel layersPanel;
        private Button btn_addpic;
        private Button btn_layers;
    }
}