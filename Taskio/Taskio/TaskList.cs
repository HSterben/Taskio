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

        public TaskList(Project p)
        {
            InitializeComponent();
            this.BackColor = SystemColors.Control;
            project = p;
            selectedTask = null;
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            using (TaskCreationForm form = new TaskCreationForm())
            {
                // Subscribe to the TaskAdded event to receive the data
                form.TaskAdded += (name, description, priority) =>
                {
                    TaskUserControl task = new TaskUserControl(name, description, priority);
                    task.TaskClicked += Task_Clicked;
                    panel.Controls.Remove(addTaskBtn);
                    panel.Controls.Add(task);
                    panel.Controls.Add(addTaskBtn);
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // The event handler will handle the data when the form is closed
                }
            }
        }
        private void Task_Clicked(object sender, EventArgs e)
        {

            if (sender is TaskUserControl clickedTask)
            {
                selectedTask = clickedTask;
                using (TaskEditForm form = new TaskEditForm(clickedTask))
                {
                    form.TaskEdited += (name, description, priority) =>
                    {
                        // Update the clicked task directly
                        clickedTask.TName = name;
                        clickedTask.Description = description;
                        clickedTask.Priority = priority;
                    };
                    form.TaskDeleted += () =>
                    {
                        panel.Controls.Remove(clickedTask);
                    };

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // If needed, handle additional logic after the task is edited
                    }
                }
            }
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