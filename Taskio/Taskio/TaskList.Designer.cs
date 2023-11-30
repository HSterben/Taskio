namespace Taskio
{
    partial class TaskList
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
            this.layoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.listTitle = new System.Windows.Forms.TextBox();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.layoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // layoutPanel
            // 
            this.layoutPanel.AutoSize = true;
            this.layoutPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.layoutPanel.Controls.Add(this.listTitle);
            this.layoutPanel.Controls.Add(this.addTaskBtn);
            this.layoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.layoutPanel.Location = new System.Drawing.Point(0, 0);
            this.layoutPanel.Name = "layoutPanel";
            this.layoutPanel.Size = new System.Drawing.Size(202, 51);
            this.layoutPanel.TabIndex = 0;
            // 
            // listTitle
            // 
            this.listTitle.BackColor = System.Drawing.SystemColors.Control;
            this.listTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listTitle.Location = new System.Drawing.Point(3, 3);
            this.listTitle.Name = "listTitle";
            this.listTitle.Size = new System.Drawing.Size(193, 16);
            this.listTitle.TabIndex = 1;
            this.listTitle.Text = "Task List 1";
            this.listTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(3, 25);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(196, 23);
            this.addTaskBtn.TabIndex = 2;
            this.addTaskBtn.Text = "+ Add a task";
            this.addTaskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.layoutPanel);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(202, 51);
            this.layoutPanel.ResumeLayout(false);
            this.layoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel layoutPanel;
        private System.Windows.Forms.TextBox listTitle;
        private System.Windows.Forms.Button addTaskBtn;
    }
}
