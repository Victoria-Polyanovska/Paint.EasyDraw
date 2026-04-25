using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint
{
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            Form1 editor = new Form1();
            editor.Show();
        }

        private void btn_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files|*.png;*.jpg;*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                Form1 editor = new Form1();
                editor.LoadImage(ofd.FileName);
                editor.Show();
                AddRecentProject(ofd.FileName);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void AddRecentProject(string filePath)
        {
            if (!listProjects.Items.Cast<ListViewItem>().Any(i => i.Text == filePath))
            {
                listProjects.Items.Add(new ListViewItem(filePath));
                SaveRecentProjects();
            }
        }
        private void listProjects_DoubleClick(object sender, EventArgs e)
        {
            if (listProjects.SelectedItems.Count > 0)
            {
                string filePath = listProjects.SelectedItems[0].Text;
                Form1 editor = new Form1();
                editor.LoadImage(filePath);
                editor.Show();
            }
        }
        private void SaveRecentProjects()
        {
            var projects = listProjects.Items.Cast<string>().ToList();
            string json = JsonSerializer.Serialize(projects);
            File.WriteAllText("recent.json", json);
        }

        private void LoadRecentProjects()
        {
            if (File.Exists("recent.json"))
            {
                string json = File.ReadAllText("recent.json");
                var projects = JsonSerializer.Deserialize<List<string>>(json);
                foreach (var p in projects)
                {
                    listProjects.Items.Add(p);
                }
            }
        }
    }
}
