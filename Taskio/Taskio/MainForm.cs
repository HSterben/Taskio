using System;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Windows.Forms;

namespace Taskio
{
    public partial class MainForm : Form
    {
        private Project project {  get; set; }
        private Task task { get; set; }
        public MainForm()
        {
            InitializeComponent();
        }

        private void chooseBackgroundImageMenuItem_Click(object sender, EventArgs e)
        {
            //to be improved if we have time
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
            TaskList taskList = new TaskList();
            this.Controls.Add(taskList);
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
            }

        }

        private void createNewProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
