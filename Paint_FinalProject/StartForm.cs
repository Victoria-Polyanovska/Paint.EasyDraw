using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Paint_FinalProject
{
    public partial class StartForm : Form
    {
        private readonly string _projectsPath = Path.Combine(Application.StartupPath, "Projects");
        public StartForm()
        {
            InitializeComponent();

            if (!Directory.Exists(_projectsPath))
            {
                Directory.CreateDirectory(_projectsPath);
            }

            LoadProjectsList();

        }
        private void LoadProjectsList()
        {
            listBoxProjects.Items.Clear();

            try
            {
                string[] files = Directory.GetFiles(_projectsPath, "*.json");

                foreach (string file in files)
                {
                    listBoxProjects.Items.Add(Path.GetFileNameWithoutExtension(file));
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при завантаженні списку: {ex.Message}");
            }
        }

        private void StartForm_Load(object sender, EventArgs e)
        {

        }

        private void button_new_Click(object sender, EventArgs e)
        {
            string projectName = Microsoft.VisualBasic.Interaction.InputBox(
               "Введіть назву для нового малюнка:",
               "Новий проект",
               "Project_" + DateTime.Now.ToString("HHmmss"));

            if (!string.IsNullOrEmpty(projectName))
            {
                OpenEditor(projectName, null);
            }
        }

        private void button_open_Click(object sender, EventArgs e)
        {
            if (listBoxProjects.SelectedItem == null)
            {
                MessageBox.Show("Будь ласка, спочатку оберіть проект зі списку!");
                return;
            }

            string selectedName = listBoxProjects.SelectedItem.ToString();
            string fullPath = Path.Combine(_projectsPath, selectedName + ".json");

            OpenEditor(selectedName, fullPath);
        }
        private void OpenEditor(string name, string path)
        {
            Paint_FinalProject.Form1 editor = new Paint_FinalProject.Form1(name, path);

            this.Hide();
            editor.ShowDialog();

            this.Show();
            LoadProjectsList();
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void listBoxProjects_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBoxProjects_DoubleClick(object sender, EventArgs e)
        {
            button_open_Click(sender, e);
        }
    }
}
