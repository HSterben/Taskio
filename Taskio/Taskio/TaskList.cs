using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Taskio
{
    public partial class TaskList : UserControl
    {
        private TaskUserControl selectedTask;
        public Project project { get; set; }
        public string TaskTitle
        {
            get { return listTitle.Text; }
            set { listTitle.Text = value; }
        }
        public MainForm mainForm { get; set; }
        public TaskList(Project p, MainForm m)
        {
            InitializeComponent();
            this.BackColor = SystemColors.Control;
            project = p;
            selectedTask = null;
            mainForm = m;
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            using (TaskCreationForm form = new TaskCreationForm(this))
            {
                form.TaskAdded += (name, description, category, priority) =>
                {
                    TaskUserControl task = new TaskUserControl(name, description, priority, category, this);
                    task.TaskEdited += taskEdited;
                    task.TaskDeleted += TaskDeleted;

                    panel.Controls.Remove(addTaskBtn);
                    panel.Controls.Add(task);
                    panel.Controls.Add(addTaskBtn);
                    project.Tasks.Add(new Task(name, description, priority, category));
                };

                form.ShowDialog();
            }
        }
        public void taskEdited(TaskUserControl taskControl)
        {

        }

        public void TaskDeleted(TaskUserControl task)
        {
            project.DeleteTaskByName(task.TName);
            panel.Controls.Remove(task);
        }
        private void utilityButton_Click(object sender, EventArgs e)
        {
            using (UtilityForm form = new UtilityForm(listTitle.Text, project.Tasks))
            {
                form.SortByNameRequested += SortTasksByName;
                form.SortByPriorityRequested += SortTasksByPriority;
                form.RenameTaskRequested += RenameTask;

                if (form.ShowDialog() == DialogResult.OK)
                {
                    listTitle.Text = form.EditedTitle;
                }

                form.SortByNameRequested -= SortTasksByName;
                form.SortByPriorityRequested -= SortTasksByPriority;
                form.RenameTaskRequested -= RenameTask;
            }
        }
        private void SortTasksByName()
        {
            var sortedControls = panel.Controls.OfType<TaskUserControl>()
                .OrderBy(t => t.TName).ToList();
            ReorderTasks(sortedControls);
        }

        private void SortTasksByPriority()
        {
            var sortedControls = panel.Controls.OfType<TaskUserControl>()
                .OrderBy(t => Convert.ToInt32(t.Priority))
                .ThenBy(t => t.TName).ToList();
            ReorderTasks(sortedControls);
        }
        private void ReorderTasks(List<TaskUserControl> sortedTasks)
        {
            foreach (Control control in panel.Controls.OfType<TaskUserControl>().ToList())
            {
                panel.Controls.Remove(control);
            }

            // Add the sorted tasks
            foreach (var task in sortedTasks)
            {
                panel.Controls.Add(task);
            }

            // Ensure the addTaskBtn is at the end
            panel.Controls.Remove(addTaskBtn);
            panel.Controls.Add(addTaskBtn);
        }
        private void RenameTask(String newName)
        {
            listTitle.Text = newName;
        }
        public void AddTask(TaskUserControl taskControl)
        {
            panel.Controls.Remove(addTaskBtn);
            panel.Controls.Add(taskControl);
            panel.Controls.Add(addTaskBtn);
        }
    }
}