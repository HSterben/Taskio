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
                if (form.ShowDialog() == DialogResult.OK) 
                {
                    //get data from the popup window and use it to add a task
                }
            }
        }
    }
}
