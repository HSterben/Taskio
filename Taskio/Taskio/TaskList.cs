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
            if(sender is TaskUserControl clickedTask) 
            {
                using (TaskEditForm form = new TaskEditForm(clickedTask))
                {
                    // Subscribe to the  event to receive the data
                    form.TaskEdited += (name, description, priority) =>
                    {
                        TaskUserControl updatedTask = new TaskUserControl(name, description, priority);
                        updatedTask.TaskClicked += Task_Clicked; // Reattach the event handler
                        panel.Controls.Remove(clickedTask);
                        panel.Controls.Add(updatedTask);
                        panel.Controls.Remove(addTaskBtn);
                        panel.Controls.Add(addTaskBtn);
                    };
                    form.TaskDeleted += () =>
                    {
                        panel.Controls.Remove(clickedTask);
                    };

                if (form.ShowDialog() == DialogResult.OK)
                    {
                        // The event handler will handle the data when the form is closed
                    }
                }
            }
        }
    }

}
