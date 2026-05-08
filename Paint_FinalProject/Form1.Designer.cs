namespace Paint_FinalProject
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
            panel1 = new Panel();
            button_clear = new Button();
            button_save = new Button();
            color_picker = new PictureBox();
            button_fill = new Button();
            button_color = new Button();
            button_add = new Button();
            button_text = new Button();
            button_rct = new Button();
            button_trg = new Button();
            button_ellipse = new Button();
            button_line = new Button();
            button_colors = new Button();
            button_eraser = new Button();
            button_pen = new Button();
            panel2 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            picture = new PictureBox();
            panel3 = new Panel();
            trackBar1 = new TrackBar();
            panelTextOptions = new Panel();
            numericFontSize = new NumericUpDown();
            comboBoxFonts = new ComboBox();
            button_u = new Button();
            button_i = new Button();
            button_b = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picture).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            panelTextOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericFontSize).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button_clear);
            panel1.Controls.Add(button_save);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(button_fill);
            panel1.Controls.Add(button_color);
            panel1.Controls.Add(button_add);
            panel1.Controls.Add(button_text);
            panel1.Controls.Add(button_rct);
            panel1.Controls.Add(button_trg);
            panel1.Controls.Add(button_ellipse);
            panel1.Controls.Add(button_line);
            panel1.Controls.Add(button_colors);
            panel1.Controls.Add(button_eraser);
            panel1.Controls.Add(button_pen);
            panel1.Location = new Point(5, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1166, 101);
            panel1.TabIndex = 0;
            // 
            // button_clear
            // 
            button_clear.BackColor = Color.Transparent;
            button_clear.BackgroundImageLayout = ImageLayout.Center;
            button_clear.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_clear.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_clear.FlatStyle = FlatStyle.Flat;
            button_clear.ForeColor = Color.White;
            button_clear.Location = new Point(1026, 53);
            button_clear.Name = "button_clear";
            button_clear.Size = new Size(104, 39);
            button_clear.TabIndex = 12;
            button_clear.Text = "Clear";
            button_clear.UseVisualStyleBackColor = false;
            // 
            // button_save
            // 
            button_save.BackColor = Color.Transparent;
            button_save.BackgroundImageLayout = ImageLayout.Center;
            button_save.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_save.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_save.FlatStyle = FlatStyle.Flat;
            button_save.ForeColor = Color.White;
            button_save.Location = new Point(1026, 8);
            button_save.Name = "button_save";
            button_save.Size = new Size(104, 39);
            button_save.TabIndex = 11;
            button_save.Text = "Save";
            button_save.UseVisualStyleBackColor = false;
            // 
            // color_picker
            // 
            color_picker.Image = Properties.Resources.color_palette;
            color_picker.Location = new Point(771, -8);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(232, 109);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 10;
            color_picker.TabStop = false;
            color_picker.MouseDown += color_picker_MouseDown;
            // 
            // button_fill
            // 
            button_fill.BackColor = Color.Transparent;
            button_fill.BackgroundImage = Properties.Resources.free_icon_paint_bucket_11443210;
            button_fill.BackgroundImageLayout = ImageLayout.Center;
            button_fill.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_fill.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_fill.FlatStyle = FlatStyle.Flat;
            button_fill.ForeColor = Color.White;
            button_fill.Location = new Point(217, 19);
            button_fill.Name = "button_fill";
            button_fill.Size = new Size(64, 67);
            button_fill.TabIndex = 8;
            button_fill.UseVisualStyleBackColor = false;
            // 
            // button_color
            // 
            button_color.BackColor = Color.White;
            button_color.Location = new Point(717, 28);
            button_color.Name = "button_color";
            button_color.Size = new Size(45, 49);
            button_color.TabIndex = 0;
            button_color.UseVisualStyleBackColor = false;
            // 
            // button_add
            // 
            button_add.BackColor = Color.Transparent;
            button_add.BackgroundImage = Properties.Resources.free_icon_plus_3524388;
            button_add.BackgroundImageLayout = ImageLayout.Center;
            button_add.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_add.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_add.FlatStyle = FlatStyle.Flat;
            button_add.ForeColor = Color.White;
            button_add.Location = new Point(637, 19);
            button_add.Name = "button_add";
            button_add.Size = new Size(64, 67);
            button_add.TabIndex = 9;
            button_add.UseVisualStyleBackColor = false;
            // 
            // button_text
            // 
            button_text.BackColor = Color.Transparent;
            button_text.BackgroundImage = Properties.Resources.free_icon_text_size_12520031;
            button_text.BackgroundImageLayout = ImageLayout.Center;
            button_text.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_text.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_text.FlatStyle = FlatStyle.Flat;
            button_text.ForeColor = Color.White;
            button_text.Location = new Point(567, 19);
            button_text.Name = "button_text";
            button_text.Size = new Size(64, 67);
            button_text.TabIndex = 7;
            button_text.UseVisualStyleBackColor = false;
            button_text.Click += button_text_Click;
            // 
            // button_rct
            // 
            button_rct.BackColor = Color.Transparent;
            button_rct.BackgroundImage = Properties.Resources.free_icon_rectangle_9369799__1_;
            button_rct.BackgroundImageLayout = ImageLayout.Center;
            button_rct.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_rct.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_rct.FlatStyle = FlatStyle.Flat;
            button_rct.ForeColor = Color.White;
            button_rct.Location = new Point(497, 19);
            button_rct.Name = "button_rct";
            button_rct.Size = new Size(64, 67);
            button_rct.TabIndex = 6;
            button_rct.UseVisualStyleBackColor = false;
            button_rct.Click += button_rct_Click;
            // 
            // button_trg
            // 
            button_trg.BackColor = Color.Transparent;
            button_trg.BackgroundImage = Properties.Resources.free_icon_triangle_outline_variant_33854;
            button_trg.BackgroundImageLayout = ImageLayout.Center;
            button_trg.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_trg.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_trg.FlatStyle = FlatStyle.Flat;
            button_trg.ForeColor = Color.White;
            button_trg.Location = new Point(427, 19);
            button_trg.Name = "button_trg";
            button_trg.Size = new Size(64, 67);
            button_trg.TabIndex = 5;
            button_trg.UseVisualStyleBackColor = false;
            button_trg.Click += button_trg_Click;
            // 
            // button_ellipse
            // 
            button_ellipse.BackColor = Color.Transparent;
            button_ellipse.BackgroundImage = Properties.Resources.free_icon_circle_274355;
            button_ellipse.BackgroundImageLayout = ImageLayout.Center;
            button_ellipse.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_ellipse.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_ellipse.FlatStyle = FlatStyle.Flat;
            button_ellipse.ForeColor = Color.White;
            button_ellipse.Location = new Point(357, 19);
            button_ellipse.Name = "button_ellipse";
            button_ellipse.Size = new Size(64, 67);
            button_ellipse.TabIndex = 4;
            button_ellipse.UseVisualStyleBackColor = false;
            button_ellipse.Click += button_ellipse_Click;
            // 
            // button_line
            // 
            button_line.BackColor = Color.Transparent;
            button_line.BackgroundImage = Properties.Resources.free_icon_line_segemnt_16118102__1_;
            button_line.BackgroundImageLayout = ImageLayout.Center;
            button_line.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_line.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_line.FlatStyle = FlatStyle.Flat;
            button_line.ForeColor = Color.White;
            button_line.Location = new Point(287, 19);
            button_line.Name = "button_line";
            button_line.Size = new Size(64, 67);
            button_line.TabIndex = 3;
            button_line.UseVisualStyleBackColor = false;
            button_line.Click += button_line_Click;
            // 
            // button_colors
            // 
            button_colors.BackColor = Color.Transparent;
            button_colors.BackgroundImage = Properties.Resources.free_icon_palette_776202;
            button_colors.BackgroundImageLayout = ImageLayout.Center;
            button_colors.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_colors.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_colors.FlatStyle = FlatStyle.Flat;
            button_colors.ForeColor = Color.White;
            button_colors.Location = new Point(147, 19);
            button_colors.Name = "button_colors";
            button_colors.Size = new Size(64, 67);
            button_colors.TabIndex = 2;
            button_colors.UseVisualStyleBackColor = false;
            // 
            // button_eraser
            // 
            button_eraser.BackColor = Color.Transparent;
            button_eraser.BackgroundImage = Properties.Resources.free_icon_eraser_2661173;
            button_eraser.BackgroundImageLayout = ImageLayout.Center;
            button_eraser.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_eraser.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_eraser.FlatStyle = FlatStyle.Flat;
            button_eraser.ForeColor = Color.White;
            button_eraser.Location = new Point(77, 19);
            button_eraser.Name = "button_eraser";
            button_eraser.Size = new Size(64, 67);
            button_eraser.TabIndex = 1;
            button_eraser.UseVisualStyleBackColor = false;
            button_eraser.Click += button_eraser_Click;
            // 
            // button_pen
            // 
            button_pen.BackColor = Color.Transparent;
            button_pen.BackgroundImage = Properties.Resources.free_icon_pencil_4898440;
            button_pen.BackgroundImageLayout = ImageLayout.Center;
            button_pen.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_pen.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_pen.FlatStyle = FlatStyle.Flat;
            button_pen.ForeColor = Color.White;
            button_pen.Location = new Point(7, 19);
            button_pen.Name = "button_pen";
            button_pen.Size = new Size(64, 67);
            button_pen.TabIndex = 0;
            button_pen.UseVisualStyleBackColor = false;
            button_pen.Click += button_pen_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button5);
            panel2.Controls.Add(button4);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(5, 638);
            panel2.Name = "panel2";
            panel2.Size = new Size(1166, 52);
            panel2.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.Transparent;
            button5.BackgroundImage = Properties.Resources.free_icon_zoom_out_17807703;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button5.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button5.FlatStyle = FlatStyle.Flat;
            button5.ForeColor = Color.White;
            button5.Location = new Point(73, 7);
            button5.Name = "button5";
            button5.Size = new Size(64, 36);
            button5.TabIndex = 16;
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Transparent;
            button4.BackgroundImage = Properties.Resources.free_icon_zoom_increasing_symbol_54862;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button4.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button4.FlatStyle = FlatStyle.Flat;
            button4.ForeColor = Color.White;
            button4.Location = new Point(3, 7);
            button4.Name = "button4";
            button4.Size = new Size(64, 36);
            button4.TabIndex = 15;
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button3.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(862, 7);
            button3.Name = "button3";
            button3.Size = new Size(158, 36);
            button3.TabIndex = 13;
            button3.Text = "Back to menu";
            button3.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImage = Properties.Resources.free_icon_forward_9333903__1_;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button2.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(1096, 7);
            button2.Name = "button2";
            button2.Size = new Size(64, 36);
            button2.TabIndex = 14;
            button2.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImage = Properties.Resources.free_icon_backward_318339__1_;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button1.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(1026, 7);
            button1.Name = "button1";
            button1.Size = new Size(64, 36);
            button1.TabIndex = 13;
            button1.UseVisualStyleBackColor = false;
            // 
            // picture
            // 
            picture.BackColor = Color.White;
            picture.Location = new Point(3, 0);
            picture.Name = "picture";
            picture.Size = new Size(926, 518);
            picture.TabIndex = 2;
            picture.TabStop = false;
            picture.MouseDown += picture_MouseDown;
            picture.MouseMove += picture_MouseMove;
            picture.MouseUp += picture_MouseUp;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(trackBar1);
            panel3.Controls.Add(picture);
            panel3.Location = new Point(5, 111);
            panel3.Name = "panel3";
            panel3.Size = new Size(1166, 521);
            panel3.TabIndex = 1;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(935, 15);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(225, 69);
            trackBar1.TabIndex = 3;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // panelTextOptions
            // 
            panelTextOptions.BackColor = Color.FromArgb(64, 64, 64);
            panelTextOptions.Controls.Add(numericFontSize);
            panelTextOptions.Controls.Add(comboBoxFonts);
            panelTextOptions.Controls.Add(button_u);
            panelTextOptions.Controls.Add(button_i);
            panelTextOptions.Controls.Add(button_b);
            panelTextOptions.Location = new Point(8, 111);
            panelTextOptions.Name = "panelTextOptions";
            panelTextOptions.Size = new Size(698, 84);
            panelTextOptions.TabIndex = 4;
            panelTextOptions.Visible = false;
            // 
            // numericFontSize
            // 
            numericFontSize.Location = new Point(468, 21);
            numericFontSize.Minimum = new decimal(new int[] { 8, 0, 0, 0 });
            numericFontSize.Name = "numericFontSize";
            numericFontSize.Size = new Size(180, 35);
            numericFontSize.TabIndex = 17;
            numericFontSize.Value = new decimal(new int[] { 12, 0, 0, 0 });
            // 
            // comboBoxFonts
            // 
            comboBoxFonts.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxFonts.FormattingEnabled = true;
            comboBoxFonts.Location = new Point(267, 21);
            comboBoxFonts.Name = "comboBoxFonts";
            comboBoxFonts.Size = new Size(182, 38);
            comboBoxFonts.TabIndex = 16;
            // 
            // button_u
            // 
            button_u.AccessibleRole = AccessibleRole.None;
            button_u.BackColor = Color.Transparent;
            button_u.BackgroundImageLayout = ImageLayout.Center;
            button_u.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_u.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_u.FlatStyle = FlatStyle.Flat;
            button_u.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_u.ForeColor = Color.White;
            button_u.Location = new Point(179, 15);
            button_u.Name = "button_u";
            button_u.Size = new Size(64, 55);
            button_u.TabIndex = 15;
            button_u.Text = "U";
            button_u.UseVisualStyleBackColor = false;
            button_u.Click += button_u_Click;
            // 
            // button_i
            // 
            button_i.AccessibleRole = AccessibleRole.None;
            button_i.BackColor = Color.Transparent;
            button_i.BackgroundImageLayout = ImageLayout.Center;
            button_i.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_i.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_i.FlatStyle = FlatStyle.Flat;
            button_i.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_i.ForeColor = Color.White;
            button_i.Location = new Point(94, 15);
            button_i.Name = "button_i";
            button_i.Size = new Size(64, 55);
            button_i.TabIndex = 14;
            button_i.Text = "I";
            button_i.UseVisualStyleBackColor = false;
            button_i.Click += button_i_Click;
            // 
            // button_b
            // 
            button_b.AccessibleRole = AccessibleRole.None;
            button_b.BackColor = Color.Transparent;
            button_b.BackgroundImageLayout = ImageLayout.Center;
            button_b.FlatAppearance.MouseDownBackColor = Color.FromArgb(192, 0, 0);
            button_b.FlatAppearance.MouseOverBackColor = Color.Maroon;
            button_b.FlatStyle = FlatStyle.Flat;
            button_b.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_b.ForeColor = Color.White;
            button_b.Location = new Point(12, 15);
            button_b.Name = "button_b";
            button_b.Size = new Size(64, 55);
            button_b.TabIndex = 13;
            button_b.Text = "B";
            button_b.UseVisualStyleBackColor = false;
            button_b.Click += button_b_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1177, 698);
            Controls.Add(panelTextOptions);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)picture).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            panelTextOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericFontSize).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox picture;
        private Panel panel3;
        private Button button_eraser;
        private Button button_pen;
        private Button button_color;
        private PictureBox color_picker;
        private Button button_add;
        private Button button_fill;
        private Button button_text;
        private Button button_rct;
        private Button button_trg;
        private Button button_ellipse;
        private Button button_line;
        private Button button_colors;
        private Button button_clear;
        private Button button_save;
        private Button button5;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button button1;
        private TrackBar trackBar1;
        private Panel panelTextOptions;
        private ComboBox comboBoxFonts;
        private Button button_u;
        private Button button_i;
        private Button button_b;
        private NumericUpDown numericFontSize;
    }
}
