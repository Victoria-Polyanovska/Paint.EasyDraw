namespace paint
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
            btn_open = new Button();
            btn_create = new Button();
            panel2 = new Panel();
            btn_exit = new Button();
            panel3 = new Panel();
            listProjects = new ListView();
            label1 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(btn_open);
            panel1.Controls.Add(btn_create);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(884, 87);
            panel1.TabIndex = 0;
            // 
            // btn_open
            // 
            btn_open.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_open.Image = (Image)resources.GetObject("btn_open.Image");
            btn_open.ImageAlign = ContentAlignment.MiddleLeft;
            btn_open.Location = new Point(259, 6);
            btn_open.Name = "btn_open";
            btn_open.Size = new Size(187, 72);
            btn_open.TabIndex = 1;
            btn_open.Text = "Open file";
            btn_open.TextAlign = ContentAlignment.MiddleRight;
            btn_open.UseVisualStyleBackColor = true;
            btn_open.Click += btn_open_Click;
            // 
            // btn_create
            // 
            btn_create.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_create.Image = (Image)resources.GetObject("btn_create.Image");
            btn_create.ImageAlign = ContentAlignment.MiddleLeft;
            btn_create.Location = new Point(18, 6);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(235, 72);
            btn_create.TabIndex = 0;
            btn_create.Text = "Create new file";
            btn_create.TextAlign = ContentAlignment.MiddleRight;
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(64, 64, 64);
            panel2.Controls.Add(btn_exit);
            panel2.Location = new Point(12, 497);
            panel2.Name = "panel2";
            panel2.Size = new Size(884, 85);
            panel2.TabIndex = 1;
            // 
            // btn_exit
            // 
            btn_exit.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point, 204);
            btn_exit.Image = (Image)resources.GetObject("btn_exit.Image");
            btn_exit.ImageAlign = ContentAlignment.MiddleLeft;
            btn_exit.Location = new Point(747, 6);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(123, 72);
            btn_exit.TabIndex = 2;
            btn_exit.Text = "Exit";
            btn_exit.TextAlign = ContentAlignment.MiddleRight;
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += btn_exit_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(64, 64, 64);
            panel3.Controls.Add(listProjects);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(884, 386);
            panel3.TabIndex = 1;
            // 
            // listProjects
            // 
            listProjects.BackColor = Color.FromArgb(64, 64, 64);
            listProjects.FullRowSelect = true;
            listProjects.GridLines = true;
            listProjects.HeaderStyle = ColumnHeaderStyle.Nonclickable;
            listProjects.Location = new Point(18, 58);
            listProjects.Name = "listProjects";
            listProjects.Size = new Size(820, 314);
            listProjects.TabIndex = 1;
            listProjects.UseCompatibleStateImageBehavior = false;
            listProjects.View = View.Details;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 14F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(18, 11);
            label1.Name = "label1";
            label1.Size = new Size(820, 32);
            label1.TabIndex = 0;
            label1.Text = "Last projects------------------------------------------------------------------------";
            // 
            // StartForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(908, 594);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "StartForm";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Panel panel3;
        private Button btn_open;
        private Button btn_create;
        private Button btn_exit;
        private ListView listProjects;
        private Label label1;
    }
}