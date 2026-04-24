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
            btn_color = new Button();
            pic_color = new Button();
            panel2 = new Panel();
            pic = new PictureBox();
            btn_fill = new Button();
            btn_pencil = new Button();
            btn_eraser = new Button();
            btn_ellips = new Button();
            btn_text = new Button();
            btn_rect = new Button();
            btn_line = new Button();
            panel3 = new Panel();
            color_picker = new PictureBox();
            btn_save = new Button();
            btn_clear = new Button();
            trackBar1 = new TrackBar();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pic).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)color_picker).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(btn_clear);
            panel1.Controls.Add(btn_save);
            panel1.Controls.Add(color_picker);
            panel1.Controls.Add(pic_color);
            panel1.Controls.Add(panel3);
            panel1.Dock = DockStyle.Top;
            panel1.ForeColor = Color.Gray;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1128, 111);
            panel1.TabIndex = 0;
            // 
            // btn_color
            // 
            btn_color.BackColor = Color.White;
            btn_color.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_color.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_color.FlatStyle = FlatStyle.Flat;
            btn_color.ForeColor = Color.White;
            btn_color.Location = new Point(9, 9);
            btn_color.Name = "btn_color";
            btn_color.Size = new Size(84, 69);
            btn_color.TabIndex = 1;
            btn_color.TextAlign = ContentAlignment.BottomCenter;
            btn_color.UseVisualStyleBackColor = false;
            // 
            // pic_color
            // 
            pic_color.BackColor = Color.White;
            pic_color.Location = new Point(737, 31);
            pic_color.Name = "pic_color";
            pic_color.Size = new Size(53, 46);
            pic_color.TabIndex = 0;
            pic_color.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Gray;
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 592);
            panel2.Name = "panel2";
            panel2.Size = new Size(1128, 32);
            panel2.TabIndex = 1;
            // 
            // pic
            // 
            pic.BackColor = Color.White;
            pic.Location = new Point(0, 117);
            pic.Name = "pic";
            pic.Size = new Size(804, 477);
            pic.TabIndex = 2;
            pic.TabStop = false;
            pic.Click += pic_Click;
            // 
            // btn_fill
            // 
            btn_fill.BackColor = Color.White;
            btn_fill.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_fill.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_fill.FlatStyle = FlatStyle.Flat;
            btn_fill.ForeColor = Color.White;
            btn_fill.Location = new Point(99, 9);
            btn_fill.Name = "btn_fill";
            btn_fill.Size = new Size(84, 69);
            btn_fill.TabIndex = 3;
            btn_fill.TextAlign = ContentAlignment.BottomCenter;
            btn_fill.UseVisualStyleBackColor = false;
            // 
            // btn_pencil
            // 
            btn_pencil.BackColor = Color.White;
            btn_pencil.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_pencil.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_pencil.FlatStyle = FlatStyle.Flat;
            btn_pencil.ForeColor = Color.White;
            btn_pencil.Location = new Point(189, 9);
            btn_pencil.Name = "btn_pencil";
            btn_pencil.Size = new Size(84, 69);
            btn_pencil.TabIndex = 4;
            btn_pencil.TextAlign = ContentAlignment.BottomCenter;
            btn_pencil.UseVisualStyleBackColor = false;
            // 
            // btn_eraser
            // 
            btn_eraser.BackColor = Color.White;
            btn_eraser.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_eraser.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_eraser.FlatStyle = FlatStyle.Flat;
            btn_eraser.ForeColor = Color.White;
            btn_eraser.Location = new Point(279, 9);
            btn_eraser.Name = "btn_eraser";
            btn_eraser.Size = new Size(84, 69);
            btn_eraser.TabIndex = 5;
            btn_eraser.TextAlign = ContentAlignment.BottomCenter;
            btn_eraser.UseVisualStyleBackColor = false;
            // 
            // btn_ellips
            // 
            btn_ellips.BackColor = Color.White;
            btn_ellips.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_ellips.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_ellips.FlatStyle = FlatStyle.Flat;
            btn_ellips.ForeColor = Color.White;
            btn_ellips.Location = new Point(459, 9);
            btn_ellips.Name = "btn_ellips";
            btn_ellips.Size = new Size(84, 69);
            btn_ellips.TabIndex = 6;
            btn_ellips.TextAlign = ContentAlignment.BottomCenter;
            btn_ellips.UseVisualStyleBackColor = false;
            // 
            // btn_text
            // 
            btn_text.BackColor = Color.White;
            btn_text.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_text.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_text.FlatStyle = FlatStyle.Flat;
            btn_text.ForeColor = Color.White;
            btn_text.Location = new Point(369, 9);
            btn_text.Name = "btn_text";
            btn_text.Size = new Size(84, 69);
            btn_text.TabIndex = 7;
            btn_text.TextAlign = ContentAlignment.BottomCenter;
            btn_text.UseVisualStyleBackColor = false;
            // 
            // btn_rect
            // 
            btn_rect.BackColor = Color.White;
            btn_rect.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_rect.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_rect.FlatStyle = FlatStyle.Flat;
            btn_rect.ForeColor = Color.White;
            btn_rect.Location = new Point(549, 9);
            btn_rect.Name = "btn_rect";
            btn_rect.Size = new Size(84, 69);
            btn_rect.TabIndex = 8;
            btn_rect.TextAlign = ContentAlignment.BottomCenter;
            btn_rect.UseVisualStyleBackColor = false;
            // 
            // btn_line
            // 
            btn_line.BackColor = Color.White;
            btn_line.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_line.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_line.FlatStyle = FlatStyle.Flat;
            btn_line.ForeColor = Color.White;
            btn_line.Location = new Point(639, 9);
            btn_line.Name = "btn_line";
            btn_line.Size = new Size(84, 69);
            btn_line.TabIndex = 9;
            btn_line.TextAlign = ContentAlignment.BottomCenter;
            btn_line.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Black;
            panel3.Controls.Add(btn_line);
            panel3.Controls.Add(btn_color);
            panel3.Controls.Add(btn_rect);
            panel3.Controls.Add(btn_fill);
            panel3.Controls.Add(btn_ellips);
            panel3.Controls.Add(btn_text);
            panel3.Controls.Add(btn_pencil);
            panel3.Controls.Add(btn_eraser);
            panel3.Location = new Point(3, 12);
            panel3.Name = "panel3";
            panel3.Size = new Size(728, 90);
            panel3.TabIndex = 3;
            // 
            // color_picker
            // 
            color_picker.Image = (Image)resources.GetObject("color_picker.Image");
            color_picker.Location = new Point(796, 6);
            color_picker.Name = "color_picker";
            color_picker.Size = new Size(219, 105);
            color_picker.SizeMode = PictureBoxSizeMode.StretchImage;
            color_picker.TabIndex = 4;
            color_picker.TabStop = false;
            // 
            // btn_save
            // 
            btn_save.BackColor = Color.Transparent;
            btn_save.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_save.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_save.FlatStyle = FlatStyle.Flat;
            btn_save.ForeColor = Color.White;
            btn_save.Location = new Point(1032, 18);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(84, 36);
            btn_save.TabIndex = 10;
            btn_save.Text = "Save";
            btn_save.TextAlign = ContentAlignment.BottomCenter;
            btn_save.UseVisualStyleBackColor = false;
            // 
            // btn_clear
            // 
            btn_clear.BackColor = Color.Transparent;
            btn_clear.FlatAppearance.MouseDownBackColor = Color.Maroon;
            btn_clear.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 0, 0);
            btn_clear.FlatStyle = FlatStyle.Flat;
            btn_clear.ForeColor = Color.White;
            btn_clear.Location = new Point(1032, 62);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(84, 36);
            btn_clear.TabIndex = 11;
            btn_clear.Text = "Clear";
            btn_clear.TextAlign = ContentAlignment.BottomCenter;
            btn_clear.UseVisualStyleBackColor = false;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(847, 134);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(257, 69);
            trackBar1.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1128, 624);
            Controls.Add(trackBar1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pic);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EasyDraw";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pic).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)color_picker).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
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
    }
}
