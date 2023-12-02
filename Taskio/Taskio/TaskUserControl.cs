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
        public TaskUserControl(string name, string description, int priority)
        {
            InitializeComponent();
            this.taskName.Text = name;
            this.priority.Text = Convert.ToString(priority);

        }
    }
}
