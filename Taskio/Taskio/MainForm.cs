using System;
using System.Drawing;
using System.IO;
using System.Linq;
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
            MessageBox.Show("Hello! Welcome to Taskio!\nTo start, please click on the file menu in the top left and either create a project or open an existing one! \nHope you enjoy!");
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

            TaskList taskList = new TaskList(project, this);
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
                DisplayTasksByCategory();
                projectProgressBar.Value = (int)project.CompletionPercentage;
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

        public void DisplayTasksByCategory()
        {
            contentLayoutPanel.Controls.Clear();

            var groupedTasks = project.Tasks.GroupBy(t => t.Category);

            foreach (var group in groupedTasks)
            {
                TaskList taskList = new TaskList(project, this)
                {
                    TaskTitle = group.Key // Set the task list title to the category name
                };

                foreach (var task in group)
                {
                    TaskUserControl taskControl = new TaskUserControl(task.Name, task.Description, task.Priority, task.Category, taskList);
                    taskList.AddTask(taskControl);
                }
                contentLayoutPanel.Controls.Add(taskList);
            }
            projectProgressBar.Value = (int)project.CompletionPercentage;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Thank you for using Taskio!");
        }
    }
}