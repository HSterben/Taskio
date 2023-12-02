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
    public partial class TaskUserControl : UserControl
    {
        private string description;
        public string Description { get; set; }
        public EventHandler TaskClicked;
        
        public TaskUserControl(string name, string description, int priority)
        {
            InitializeComponent();
            this.taskName.Text = name;
            this.priority.Text = Convert.ToString(priority);
            this.Description = description;

            
            this.Click += TaskUserControl_Click;
        }
        private void TaskUserControl_Click(object sender, EventArgs e)
        {
            // Raise the TaskClicked event when the TaskUserControl is clicked
            TaskClicked?.Invoke(this, EventArgs.Empty);
        }


    }
}
