using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taskio
{
    public partial class TaskCreationForm : Form
    {
        // Define a custom event to pass the data to the parent form (TaskList)
        public event Action<string, string, int> TaskAdded;

        public TaskCreationForm()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = nameText.Text;
            string description = descriptionText.Text;
            int priority = Convert.ToInt32(this.priority.Value);

            // Raise the TaskAdded event and pass the data
            TaskAdded?.Invoke(name, description, priority);

            // Close the form
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }

}
