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
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.listTitle = new System.Windows.Forms.TextBox();
            this.addTaskBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.listTitle);
            this.panel.Controls.Add(this.addTaskBtn);
            this.panel.Controls.Add(this.button1);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(302, 123);
            this.panel.TabIndex = 0;
            // 
            // listTitle
            // 
            this.listTitle.BackColor = System.Drawing.SystemColors.Control;
            this.listTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.listTitle.Location = new System.Drawing.Point(4, 5);
            this.listTitle.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listTitle.Name = "listTitle";
            this.listTitle.ReadOnly = true;
            this.listTitle.Size = new System.Drawing.Size(290, 23);
            this.listTitle.TabIndex = 1;
            this.listTitle.Text = "New Task List";
            this.listTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addTaskBtn
            // 
            this.addTaskBtn.Location = new System.Drawing.Point(4, 38);
            this.addTaskBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addTaskBtn.Name = "addTaskBtn";
            this.addTaskBtn.Size = new System.Drawing.Size(294, 35);
            this.addTaskBtn.TabIndex = 2;
            this.addTaskBtn.Text = "+ Add a task";
            this.addTaskBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTaskBtn.UseVisualStyleBackColor = true;
            this.addTaskBtn.Click += new System.EventHandler(this.addTaskBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(255, 83);
            this.button1.Margin = new System.Windows.Forms.Padding(255, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(42, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TaskList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.panel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(302, 123);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.TextBox listTitle;
        private System.Windows.Forms.Button addTaskBtn;
        private System.Windows.Forms.Button button1;
    }
}
