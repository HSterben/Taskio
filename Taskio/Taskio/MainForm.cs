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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void fileDialogue_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void chooseBackgroundImageMenuItem_Click(object sender, EventArgs e)
        {
            fileDialogue.Filter = "Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp) | *.jpg; *.jpeg; *.png; *.gif; *.bmp";
            if (fileDialogue.ShowDialog() == DialogResult.OK)
            {
                this.BackgroundImage = Image.FromFile(fileDialogue.FileName);
            }
        }
    }
}
