namespace Paint_FinalProject
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            panel1 = new Panel();
            button_open = new Button();
            button_new = new Button();
            panel3 = new Panel();
            label1 = new Label();
            listBoxProjects = new ListBox();
            panel2 = new Panel();
            button_exit = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(button_open);
            panel1.Controls.Add(button_new);
            panel1.Location = new Point(2, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 101);
            panel1.TabIndex = 1;
            // 
            // button_open
            // 
            button_open.BackgroundImage = (Image)resources.GetObject("button_open.BackgroundImage");
            button_open.BackgroundImageLayout = ImageLayout.None;
            button_open.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_open.Location = new Point(261, 8);
            button_open.Name = "button_open";
            button_open.Size = new Size(196, 76);
            button_open.TabIndex = 1;
            button_open.Text = "Open file";
            button_open.TextAlign = ContentAlignment.MiddleRight;
            button_open.UseVisualStyleBackColor = true;
            button_open.Click += button_open_Click;
            // 
            // button_new
            // 
            button_new.BackgroundImage = (Image)resources.GetObject("button_new.BackgroundImage");
            button_new.BackgroundImageLayout = ImageLayout.None;
            button_new.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_new.Location = new Point(7, 8);
            button_new.Name = "button_new";
            button_new.Size = new Size(248, 76);
            button_new.TabIndex = 0;
            button_new.Text = "Create new file";
            button_new.TextAlign = ContentAlignment.MiddleRight;
            button_new.UseVisualStyleBackColor = true;
            button_new.Click += button_new_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(listBoxProjects);
            panel3.Location = new Point(2, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 481);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.ForeColor = Color.White;
            label1.Location = new Point(16, 11);
            label1.Name = "label1";
            label1.Size = new Size(177, 38);
            label1.TabIndex = 1;
            label1.Text = "Last projects";
            // 
            // listBoxProjects
            // 
            listBoxProjects.FormattingEnabled = true;
            listBoxProjects.ItemHeight = 30;
            listBoxProjects.Location = new Point(16, 65);
            listBoxProjects.Name = "listBoxProjects";
            listBoxProjects.Size = new Size(669, 394);
            listBoxProjects.TabIndex = 0;
            listBoxProjects.DoubleClick += listBoxProjects_DoubleClick;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(button_exit);
            panel2.Location = new Point(2, 606);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 77);
            panel2.TabIndex = 3;
            // 
            // button_exit
            // 
            button_exit.BackgroundImage = (Image)resources.GetObject("button_exit.BackgroundImage");
            button_exit.BackgroundImageLayout = ImageLayout.None;
            button_exit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button_exit.Location = new Point(745, 7);
            button_exit.Name = "button_exit";
            button_exit.Size = new Size(131, 67);
            button_exit.TabIndex = 2;
            button_exit.Text = "Exit";
            button_exit.TextAlign = ContentAlignment.MiddleRight;
            button_exit.UseVisualStyleBackColor = true;
            button_exit.Click += button_exit_Click;
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(890, 689);
            Controls.Add(panel2);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "StartForm";
            Load += StartForm_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button button_open;
        private Button button_new;
        private Panel panel3;
        private Label label1;
        private ListBox listBoxProjects;
        private Panel panel2;
        private Button button_exit;
    }
}