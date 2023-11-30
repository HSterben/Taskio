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
    public partial class TaskList : UserControl
    {
        public TaskList()
        {
            InitializeComponent();
        }

        private void addTaskBtn_Click(object sender, EventArgs e)
        {
            using (TaskCreationForm form = new TaskCreationForm())
            {
                // Subscribe to the TaskAdded event to receive the data
                form.TaskAdded += (name, description, priority) =>
                {
                    

                    // Use the data to add a task (you can implement your logic here)
                    // For now, let's just display the data in a message box
                    MessageBox.Show($"Name: {name}, Description: {description}, Priority: {priority}");
                };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    // The event handler will handle the data when the form is closed
                }
            }
        }
    }

}
