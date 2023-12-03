using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Taskio
{
    public partial class UtilityForm : Form
    {
        public event Action SortByNameRequested;
        public event Action SortByPriorityRequested;
        public event Action<string> RenameTaskRequested;
        public string EditedTitle { get; private set; }
        public List<Task> SortedTasks { get; private set; }
        public UtilityForm(string currentTitle, List<Task> tasks)
        {
            InitializeComponent();
            newTaskNameTextBox.Text = currentTitle;
        }

        private void sortByPriorityButton_Click(object sender, EventArgs e)
        {
            SortByPriorityRequested?.Invoke();
        }

        private void sortByNameButton_Click(object sender, EventArgs e)
        {
            SortByNameRequested?.Invoke();

        }

        private void TaskNameUpdateButton_Click(object sender, EventArgs e)
        {
            string newTaskName = newTaskNameTextBox.Text;
            RenameTaskRequested?.Invoke(newTaskName);
        }
    }
}
