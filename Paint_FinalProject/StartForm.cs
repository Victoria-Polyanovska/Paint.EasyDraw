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
        private readonly string _historyFile = Path.Combine(Application.StartupPath, "recent_files.txt");
        private void LoadProjectsList()
        {
            listBoxProjects.Items.Clear();

            if (!File.Exists(_historyFile)) return;

            try
            {
                string[] paths = File.ReadAllLines(_historyFile);

                foreach (string path in paths)
                {
                    if (File.Exists(path)) 
                    {
                        listBoxProjects.Items.Add(path);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка історії: {ex.Message}");
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
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Всі підтримувані файли|*.json;*.png;*.jpg;*.jpeg;*.bmp|Проекти JSON|*.json|Зображення|*.png;*.jpg;*.jpeg;*.bmp";
                ofd.Title = "Оберіть файл для редагування";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string fileName = Path.GetFileNameWithoutExtension(ofd.FileName);
                    OpenEditor(fileName, ofd.FileName);
                }
            }
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
            if (listBoxProjects.SelectedItem != null)
            {
                string fullPath = listBoxProjects.SelectedItem.ToString();

                if (File.Exists(fullPath))
                {
                    string fileName = Path.GetFileNameWithoutExtension(fullPath);
                    OpenEditor(fileName, fullPath);
                }
                else
                {
                    MessageBox.Show("Цей файл більше не існує за вказаним шляхом.");
                    LoadProjectsList(); 
                }
            }
        }
    }
}
