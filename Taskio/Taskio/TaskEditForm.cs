using System;
using System.Windows.Forms;

namespace Taskio
{
    public partial class TaskEditForm : Form
    {
        private TaskUserControl associatedTask;
        public event Action<string, string, string, int> TaskEdited;
        public event Action TaskDeleted;
        public TaskList TaskList { get; set; }
        public TaskEditForm(TaskUserControl task, TaskList taskList)
        {
            InitializeComponent();
            this.nameText.Text = task.TName;
            this.descriptionText.Text = task.Description;
            this.priority.Text = task.Priority.ToString();
            this.categoryTextBox.Text = task.Category;
            associatedTask = task;
            TaskList = taskList;
        }
        private void editBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string description = descriptionText.Text;
            int priority = Convert.ToInt32(this.priority.Value);
            string category = categoryTextBox.Text;
            associatedTask.Name = name;
            associatedTask.Description = description;
            associatedTask.Priority = priority;
            associatedTask.Category = categoryTextBox.Text;
            TaskEdited?.Invoke(name, description,category, priority);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            TaskList.panel.Controls.Remove(associatedTask);
            TaskList.TaskDeleted(associatedTask);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
