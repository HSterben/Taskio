using System;
using System.Windows.Forms;

namespace Taskio
{
    public partial class TaskUserControl : UserControl
    {
        public String Description { get; set; }
        public string TName { get; set; }
        public int Priority { get; set; }
        public String Category { get; set; }
        public EventHandler TaskClicked;
        public event Action<TaskUserControl> TaskEdited;
        public event Action<TaskUserControl> TaskDeleted;
        public TaskList list { get; set; }

        public TaskUserControl(string name, string description, int priority, string category, TaskList t)
        {
            InitializeComponent();
            this.taskName.Text = name;
            this.priority.Text = Convert.ToString(priority);
            this.Description = description;
            this.TName = name;
            this.Priority = priority;
            list = t;
            Priority = priority;
            Category = category;
            this.Click += TaskUserControl_Click;
            AttachClickEventToChildren(this);
        }
        private void AttachClickEventToChildren(Control parent)
        {
            foreach (Control child in parent.Controls)
            {
                child.Click += TaskUserControl_Click;

                // Recursively attach to children of the child, if any
                if (child.HasChildren)
                {
                    AttachClickEventToChildren(child);
                }
            }
        }
        private void TaskUserControl_Click(object sender, EventArgs e)
        {
            TaskClicked?.Invoke(this, EventArgs.Empty);
        }

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            TaskClicked?.Invoke(this, EventArgs.Empty);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            using (TaskEditForm form = new TaskEditForm(this, list))
            {
                form.TaskEdited += (name, description, category, priority) =>
                {
                    Console.WriteLine("First name: " + name + ", Second name: " + TName);
                    this.taskName.Text = name;
                    this.priority.Text = Convert.ToString(priority);
                    this.Description = description;
                    this.Priority = priority;
                    this.Category = category;
                    this.TName = name;
                    string oldName = this.TName;
                    list.project.UpdateProjectTaskData(this, oldName);
                    list.project.SaveTasks();
                    TaskEdited?.Invoke(this);
                    list.mainForm.DisplayTasksByCategory();
                };
                form.TaskDeleted += () =>
                {
                    TaskDeleted?.Invoke(this);
                };
                form.ShowDialog();
            }
        }

    }
}
