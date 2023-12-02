﻿namespace Taskio
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
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel
            // 
            this.panel.AutoSize = true;
            this.panel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel.Controls.Add(this.listTitle);
            this.panel.Controls.Add(this.addTaskBtn);
            this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.panel.Location = new System.Drawing.Point(0, 0);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(202, 51);
            this.panel.TabIndex = 0;
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
            this.listTitle.Text = "New Task List";
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
            this.Controls.Add(this.panel);
            this.Name = "TaskList";
            this.Size = new System.Drawing.Size(202, 51);
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.TextBox listTitle;
        private System.Windows.Forms.Button addTaskBtn;
    }
}
