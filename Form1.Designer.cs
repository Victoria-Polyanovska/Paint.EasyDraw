namespace paint
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            panel3 = new Panel();
            btn_addpic = new Button();
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
            btn_back = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            textOptionsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)fontSizeComboBoxInPanel).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Black;
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Gray;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1304, 111);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(btn_addpic);
            panel3.Controls.Add(btn_trg);
            panel3.Controls.Add(pic_color);
            panel3.Controls.Add(color_picker);
            panel3.Controls.Add(btn_clear);
            panel3.Controls.Add(btn_line);
            panel3.Controls.Add(btn_save);
            panel3.Controls.Add(btn_color);
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
            // 
            // btn_addpic
            // 
            btn_addpic.BackColor = Color.Transparent;
            btn_addpic.BackgroundImageLayout = ImageLayout.Center;
            btn_addpic.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_addpic.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_addpic.FlatStyle = FlatStyle.Flat;
            btn_addpic.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_addpic.ForeColor = Color.White;
            btn_addpic.Image = (Image)resources.GetObject("btn_addpic.Image");
            btn_addpic.Location = new Point(747, 9);
            btn_addpic.Name = "btn_addpic";
            btn_addpic.Size = new Size(75, 69);
            btn_addpic.TabIndex = 23;
            btn_addpic.UseVisualStyleBackColor = false;
            btn_addpic.Click += btn_addpic_Click;
            // 
            // btn_trg
            // 
            btn_trg.BackColor = Color.Transparent;
            btn_trg.BackgroundImage = (Image)resources.GetObject("btn_trg.BackgroundImage");
            btn_trg.BackgroundImageLayout = ImageLayout.Center;
            btn_trg.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_trg.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_trg.FlatStyle = FlatStyle.Flat;
            btn_trg.ForeColor = Color.Transparent;
            btn_trg.Location = new Point(666, 9);
            btn_trg.Name = "btn_trg";
            btn_trg.Size = new Size(75, 69);
            btn_trg.TabIndex = 10;
            btn_trg.TextAlign = ContentAlignment.BottomRight;
            btn_trg.UseVisualStyleBackColor = false;
            btn_trg.Click += btn_trg_Click_1;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(909, 26);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(44, 40);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // color_picker
            // 
            color_picker.Image = (Image)resources.GetObject("color_picker.Image");
            color_picker.Location = new Point(959, 6);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(230, 81);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 4;
            color_picker.TabStop = false;
            color_picker.MouseClick += color_picker_MouseClick;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.FromArgb(64, 64, 64);
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(1195, 51);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(84, 36);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.TextAlign = ContentAlignment.TopCenter;
            btn_clear.UseVisualStyleBackColor = false;
            btn_clear.Click += btn_clear_Click;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.Transparent;
            btn_line.BackgroundImage = (Image)resources.GetObject("btn_line.BackgroundImage");
            btn_line.BackgroundImageLayout = ImageLayout.Center;
            btn_line.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.Transparent;
            btn_line.Location = new Point(585, 9);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(75, 69);
            btn_line.TabIndex = 9;
            btn_line.TextAlign = ContentAlignment.BottomRight;
            btn_line.UseVisualStyleBackColor = false;
            btn_line.Click += btn_line_Click_1;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.FromArgb(64, 64, 64);
            btn_save.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(1195, 9);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(84, 36);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save";
            btn_save.TextAlign = ContentAlignment.TopCenter;
            btn_save.UseVisualStyleBackColor = false;
            btn_save.Click += btn_save_Click;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.Transparent;
            btn_color.BackgroundImage = (Image)resources.GetObject("btn_color.BackgroundImage");
            btn_color.BackgroundImageLayout = ImageLayout.Center;
            btn_color.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Location = new Point(3, 9);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(78, 69);
            btn_color.TabIndex = 1;
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            btn_color.Click += btn_color_Click_1;
            // 
            // btn_rect
            // 
            btn_rect.BackColor = Color.Transparent;
            btn_rect.BackgroundImageLayout = ImageLayout.Center;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.Transparent;
            btn_rect.Image = (Image)resources.GetObject("btn_rect.Image");
            btn_rect.Location = new Point(504, 9);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(75, 69);
            btn_rect.TabIndex = 8;
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = false;
            btn_rect.Click += btn_rect_Click_1;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.Transparent;
            btn_fill.BackgroundImage = (Image)resources.GetObject("btn_fill.BackgroundImage");
            btn_fill.BackgroundImageLayout = ImageLayout.Center;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Location = new Point(87, 9);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(78, 69);
            btn_fill.TabIndex = 3;
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            btn_fill.Click += btn_fill_Click_1;
            // 
            // btn_ellips
            // 
            btn_ellips.BackColor = Color.Transparent;
            btn_ellips.BackgroundImage = (Image)resources.GetObject("btn_ellips.BackgroundImage");
            btn_ellips.BackgroundImageLayout = ImageLayout.Center;
            btn_ellips.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_ellips.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_ellips.FlatStyle = FlatStyle.Flat;
            btn_ellips.ForeColor = Color.White;
            btn_ellips.Location = new Point(423, 9);
            btn_ellips.Name = "btn_ellips";
            btn_ellips.Size = new Size(75, 69);
            btn_ellips.TabIndex = 6;
            btn_ellips.TextAlign = ContentAlignment.BottomCenter;
            btn_ellips.UseVisualStyleBackColor = false;
            btn_ellips.Click += btn_ellips_Click_1;
            // 
            // btn_text
            // 
            btn_text.BackColor = Color.Transparent;
            btn_text.BackgroundImage = (Image)resources.GetObject("btn_text.BackgroundImage");
            btn_text.BackgroundImageLayout = ImageLayout.Center;
            btn_text.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_text.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_text.FlatStyle = FlatStyle.Flat;
            btn_text.ForeColor = Color.White;
            btn_text.Location = new Point(342, 9);
            btn_text.Name = "btn_text";
            btn_text.Size = new Size(75, 69);
            btn_text.TabIndex = 7;
            btn_text.TextAlign = ContentAlignment.BottomCenter;
            btn_text.UseVisualStyleBackColor = false;
            btn_text.Click += btn_text_Click;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.Transparent;
            btn_pencil.BackgroundImage = (Image)resources.GetObject("btn_pencil.BackgroundImage");
            btn_pencil.BackgroundImageLayout = ImageLayout.Center;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Location = new Point(171, 9);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(84, 69);
            btn_pencil.TabIndex = 4;
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = false;
            btn_pencil.Click += btn_pencil_Click_1;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.Transparent;
            btn_eraser.BackgroundImage = (Image)resources.GetObject("btn_eraser.BackgroundImage");
            btn_eraser.BackgroundImageLayout = ImageLayout.Center;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Location = new Point(261, 9);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(75, 69);
            btn_eraser.TabIndex = 5;
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = false;
            btn_eraser.Click += btn_eraser_Click_1;
            // 
            // btn_back
            // 
            btn_back.BackColor = Color.FromArgb(64, 64, 64);
            btn_back.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_back.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_back.FlatStyle = FlatStyle.Flat;
            btn_back.ForeColor = Color.White;
            btn_back.Location = new Point(948, 11);
            btn_back.Name = "btn_back";
            btn_back.Size = new Size(170, 36);
            btn_back.TabIndex = 13;
            btn_back.Text = "Back to menu";
            btn_back.TextAlign = ContentAlignment.TopCenter;
            btn_back.UseVisualStyleBackColor = false;
            btn_back.Click += btn_back_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Black;
            panel2.Controls.Add(panel4);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 616);
            panel2.Name = "panel2";
            panel2.Size = new Size(1304, 78);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(64, 64, 64);
            panel4.Controls.Add(btn_zoomout);
            panel4.Controls.Add(btn_back);
            panel4.Controls.Add(btn_zoomin);
            panel4.Controls.Add(btn_redo);
            panel4.Controls.Add(btn_undo);
            panel4.Location = new Point(3, 12);
            panel4.Name = "panel4";
            panel4.Size = new Size(1325, 54);
            panel4.TabIndex = 2;
            // 
            // btn_zoomout
            // 
            btn_zoomout.BackColor = Color.FromArgb(64, 64, 64);
            btn_zoomout.BackgroundImage = (Image)resources.GetObject("btn_zoomout.BackgroundImage");
            btn_zoomout.BackgroundImageLayout = ImageLayout.Center;
            btn_zoomout.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_zoomout.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_zoomout.FlatStyle = FlatStyle.Flat;
            btn_zoomout.ForeColor = Color.White;
            btn_zoomout.Location = new Point(93, 11);
            btn_zoomout.Name = "btn_zoomout";
            btn_zoomout.Size = new Size(84, 36);
            btn_zoomout.TabIndex = 14;
            btn_zoomout.TextAlign = ContentAlignment.BottomCenter;
            btn_zoomout.UseVisualStyleBackColor = false;
            // 
            // btn_zoomin
            // 
            btn_zoomin.BackColor = Color.FromArgb(64, 64, 64);
            btn_zoomin.BackgroundImage = (Image)resources.GetObject("btn_zoomin.BackgroundImage");
            btn_zoomin.BackgroundImageLayout = ImageLayout.Center;
            btn_zoomin.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_zoomin.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_zoomin.FlatStyle = FlatStyle.Flat;
            btn_zoomin.ForeColor = Color.White;
            btn_zoomin.Location = new Point(3, 11);
            btn_zoomin.Name = "btn_zoomin";
            btn_zoomin.Size = new Size(84, 36);
            btn_zoomin.TabIndex = 13;
            btn_zoomin.TextAlign = ContentAlignment.BottomCenter;
            btn_zoomin.UseVisualStyleBackColor = false;
            // 
            // btn_redo
            // 
            btn_redo.BackColor = Color.FromArgb(64, 64, 64);
            btn_redo.BackgroundImage = (Image)resources.GetObject("btn_redo.BackgroundImage");
            btn_redo.BackgroundImageLayout = ImageLayout.Center;
            btn_redo.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_redo.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_redo.FlatStyle = FlatStyle.Flat;
            btn_redo.ForeColor = Color.White;
            btn_redo.Location = new Point(1214, 11);
            btn_redo.Name = "btn_redo";
            btn_redo.Size = new Size(84, 36);
            btn_redo.TabIndex = 12;
            btn_redo.TextAlign = ContentAlignment.BottomCenter;
            btn_redo.UseVisualStyleBackColor = false;
            btn_redo.Click += btn_redo_Click;
            // 
            // btn_undo
            // 
            btn_undo.BackColor = Color.FromArgb(64, 64, 64);
            btn_undo.BackgroundImage = (Image)resources.GetObject("btn_undo.BackgroundImage");
            btn_undo.BackgroundImageLayout = ImageLayout.Center;
            btn_undo.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_undo.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_undo.FlatStyle = FlatStyle.Flat;
            btn_undo.ForeColor = Color.White;
            btn_undo.Location = new Point(1124, 11);
            btn_undo.Name = "btn_undo";
            btn_undo.Size = new Size(84, 36);
            btn_undo.TabIndex = 11;
            btn_undo.TextAlign = ContentAlignment.BottomCenter;
            btn_undo.UseVisualStyleBackColor = false;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Location = new Point(6, 117);
            pic.Name = "pic";
            pic.Size = new Size(877, 493);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Paint += pic_Paint_1;
            pic.MouseClick += pic_MouseClick;
            pic.MouseDown += pic_MouseDown;
            pic.MouseMove += pic_MouseMove;
            pic.MouseUp += pic_MouseUp;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(1008, 117);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(293, 69);
            trackBar1.TabIndex = 3;
            trackBar1.ValueChanged += trackBar1_ValueChanged_2;
            // 
            // textOptionsPanel
            // 
            textOptionsPanel.BackColor = SystemColors.WindowFrame;
            textOptionsPanel.Controls.Add(btn_u);
            textOptionsPanel.Controls.Add(btn_i);
            textOptionsPanel.Controls.Add(btn_b);
            textOptionsPanel.Controls.Add(fontSizeComboBoxInPanel);
            textOptionsPanel.Controls.Add(fontComboBoxInPanel);
            textOptionsPanel.Location = new Point(1004, 179);
            textOptionsPanel.Name = "textOptionsPanel";
            textOptionsPanel.Size = new Size(288, 174);
            textOptionsPanel.TabIndex = 4;
            textOptionsPanel.Visible = false;
            // 
            // btn_u
            // 
            btn_u.BackColor = Color.Transparent;
            btn_u.BackgroundImageLayout = ImageLayout.Center;
            btn_u.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_u.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_u.FlatStyle = FlatStyle.Flat;
            btn_u.Font = new Font("Arial", 16F, FontStyle.Underline, GraphicsUnit.Point, 204);
            btn_u.ForeColor = Color.White;
            btn_u.Location = new Point(159, 13);
            btn_u.Name = "btn_u";
            btn_u.Size = new Size(44, 42);
            btn_u.TabIndex = 16;
            btn_u.Text = "U";
            btn_u.UseVisualStyleBackColor = false;
            btn_u.Click += btn_u_Click;
            // 
            // btn_i
            // 
            btn_i.BackColor = Color.Transparent;
            btn_i.BackgroundImageLayout = ImageLayout.Center;
            btn_i.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_i.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_i.FlatStyle = FlatStyle.Flat;
            btn_i.Font = new Font("Arial", 16F, FontStyle.Italic, GraphicsUnit.Point, 204);
            btn_i.ForeColor = Color.White;
            btn_i.Location = new Point(90, 13);
            btn_i.Name = "btn_i";
            btn_i.Size = new Size(44, 42);
            btn_i.TabIndex = 15;
            btn_i.Text = "I";
            btn_i.UseVisualStyleBackColor = false;
            btn_i.Click += btn_i_Click;
            // 
            // btn_b
            // 
            btn_b.BackColor = Color.Transparent;
            btn_b.BackgroundImageLayout = ImageLayout.Center;
            btn_b.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_b.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_b.FlatStyle = FlatStyle.Flat;
            btn_b.Font = new Font("Arial", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_b.ForeColor = Color.White;
            btn_b.Location = new Point(20, 13);
            btn_b.Name = "btn_b";
            btn_b.Size = new Size(44, 42);
            btn_b.TabIndex = 14;
            btn_b.Text = "B";
            btn_b.UseVisualStyleBackColor = false;
            btn_b.Click += btn_b_Click;
            // 
            // fontSizeComboBoxInPanel
            // 
            fontSizeComboBoxInPanel.Location = new Point(20, 70);
            fontSizeComboBoxInPanel.Name = "fontSizeComboBoxInPanel";
            fontSizeComboBoxInPanel.Size = new Size(197, 35);
            fontSizeComboBoxInPanel.TabIndex = 1;
            // 
            // fontComboBoxInPanel
            // 
            fontComboBoxInPanel.FormattingEnabled = true;
            fontComboBoxInPanel.Location = new Point(20, 120);
            fontComboBoxInPanel.Name = "fontComboBoxInPanel";
            fontComboBoxInPanel.Size = new Size(197, 38);
            fontComboBoxInPanel.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1304, 694);
            Controls.Add(textOptionsPanel);
            Controls.Add(trackBar1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EasyDraw";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            textOptionsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)fontSizeComboBoxInPanel).EndInit();
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
        private Button btn_addpic;
    }
}
