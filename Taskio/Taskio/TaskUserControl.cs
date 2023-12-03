using System;
using System.Windows.Forms;

namespace Taskio
{
    public partial class TaskUserControl : UserControl
    {
        public String Description { get; set; }
        private string _tName;
        public string TName { get; set; }
        public int Priority { get; set; }
        public EventHandler TaskClicked;

        public TaskUserControl(string name, string description, int priority)
        {
            InitializeComponent();
            this.taskName.Text = name;
            this.priority.Text = Convert.ToString(priority);
            this.Description = description;
            this.TName = name;
            this.Priority = priority;

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
    }
}
