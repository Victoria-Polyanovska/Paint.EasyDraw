namespace paint
{
    partial class paint
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(paint));
            panel1 = new Panel();
            btn_open = new Button();
            btn_create = new Button();
            panel2 = new Panel();
            panel3 = new Panel();
            button1 = new Button();
            label1 = new Label();
            listView1 = new ListView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btn_create);
            panel1.Controls.Add(btn_open);
            panel1.Location = new Point(12, 9);
            panel1.Name = "panel1";
            panel1.Size = new Size(888, 89);
            panel1.TabIndex = 0;
            // 
            // btn_open
            // 
            btn_open.Image = (Image)resources.GetObject("btn_open.Image");
            btn_open.ImageAlign = ContentAlignment.MiddleLeft;
            btn_open.Location = new Point(237, 8);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(218, 70);
            btn_open.TabIndex = 1;
            btn_open.Text = "Open file";
            btn_open.TextAlign = ContentAlignment.MiddleRight;
            btn_open.UseVisualStyleBackColor = true;
            // 
            // btn_create
            // 
            btn_create.Image = (Image)resources.GetObject("btn_create.Image");
            btn_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_create.Location = new Point(13, 8);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(218, 70);
            btn_create.TabIndex = 0;
            btn_create.Text = "Create new file";
            btn_create.TextAlign = ContentAlignment.MiddleRight;
            btn_create.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button1);
            panel2.Location = new Point(12, 538);
            panel2.Name = "panel2";
            panel2.Size = new Size(888, 69);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 104);
            panel3.Name = "panel3";
            panel3.Size = new Size(888, 428);
            panel3.TabIndex = 2;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(759, 8);
            button1.Name = "button1";
            button1.Size = new Size(120, 54);
            button1.TabIndex = 2;
            button1.Text = "Exit";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(145, 26);
            label1.TabIndex = 0;
            label1.Text = "Last projects";
            // 
            // listView1
            // 
            listView1.BackColor = Color.FromArgb(64, 64, 64);
            listView1.FullRowSelect = true;
            listView1.GridLines = true;
            listView1.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listView1.Location = new Point(13, 64);
            listView1.Name = "listView1";
            listView1.Size = new Size(866, 361);
            listView1.TabIndex = 1;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.Details;
            // 
            // paint
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(912, 607);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "paint";
            Text = "StartForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Button btn_create;
        private Panel panel3;
        private Button btn_open;
        private Button button1;
        private Label label1;
        private ListView listView1;
    }
}