using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Taskio
{
    public partial class MainForm : Form
    {
        private Project project { get; set; }
        private Task task { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void chooseBackgroundImageMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            string exeDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
            DirectoryInfo parentDirectory = Directory.GetParent(exeDirectory);
            if (parentDirectory != null)
            {
                fileDialog.InitialDirectory = parentDirectory.FullName;
            }
            fileDialog.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(fileDialog.FileName);
            }
        }

        private void createTaskListMenuItem_Click(object sender, EventArgs e)
        {
            if (project == null)
            {
                MessageBox.Show("Please open a project first.");
                return;
            }

            TaskList taskList = new TaskList(project);
            contentLayoutPanel.Controls.Add(taskList);
        }

        private void openProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "JSON Files (*.json)|*.json";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;
                project = new Project(filePath);
                project.LoadProject();
                this.Text = $"Taskio | {project.Name}";
            }
        }

        private void createNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "JSON Files (*.json)|*.json";
            saveFileDialog.Title = "Create New Project";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName;
                project = new Project();
                project.CreateJSONFile(Path.GetDirectoryName(filePath), Path.GetFileName(filePath));
                this.Text = $"Taskio | {project.Name}";
            }
        }
    }
}