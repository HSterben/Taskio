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
                    Task task = new Task(name, description, priority);
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
    }

}
