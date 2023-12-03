using System;
using System.Windows.Forms;

namespace Taskio
{
    public partial class TaskEditForm : Form
    {
        private TaskUserControl associatedTask;
        public TaskEditForm(TaskUserControl task)
        {
            InitializeComponent();
            this.nameText.Text = task.TName;
            this.descriptionText.Text = task.Description;
            this.priority.Text = task.Priority.ToString();
            associatedTask = task;

        }
        // Define custom events to pass the data to the parent form (TaskList)
        public event Action<string, string, int> TaskEdited;
        public event Action TaskDeleted;
        private void editBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string description = descriptionText.Text;
            int priority = Convert.ToInt32(this.priority.Value);

            // Raise the TaskAdded event and pass the data
            TaskEdited?.Invoke(name, description, priority);

            // Close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            TaskDeleted?.Invoke();
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
