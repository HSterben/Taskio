namespace Taskio
{
    partial class TaskUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.priority = new System.Windows.Forms.Label();
            this.taskName = new System.Windows.Forms.Label();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // priority
            // 
            this.priority.AutoSize = true;
            this.priority.Location = new System.Drawing.Point(17, 0);
            this.priority.Margin = new System.Windows.Forms.Padding(9, 0, 4, 0);
            this.priority.Name = "priority";
            this.priority.Size = new System.Drawing.Size(0, 20);
            this.priority.TabIndex = 0;
            // 
            // taskName
            // 
            this.taskName.AutoSize = true;
            this.taskName.Location = new System.Drawing.Point(4, 0);
            this.taskName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.taskName.Name = "taskName";
            this.taskName.Size = new System.Drawing.Size(0, 20);
            this.taskName.TabIndex = 1;
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.taskName);
            this.panel.Controls.Add(this.priority);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(281, 27);
            this.panel.TabIndex = 0;
            // 
            // TaskUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskUserControl";
            this.Size = new System.Drawing.Size(281, 27);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label priority;
        private System.Windows.Forms.Label taskName;
        private System.Windows.Forms.FlowLayoutPanel panel;
    }
}
