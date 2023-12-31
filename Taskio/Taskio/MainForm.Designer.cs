﻿namespace Taskio
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewProjectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chooseBackgroundImageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taskListsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createTaskListMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileDialogue = new System.Windows.Forms.OpenFileDialog();
            this.contentLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.projectProgressBar = new System.Windows.Forms.ProgressBar();
            this.progressLabel = new System.Windows.Forms.Label();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menu.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.taskListsMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(1024, 33);
            this.menu.TabIndex = 0;
            this.menu.Text = "Menu";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openProjectToolStripMenuItem,
            this.createNewProjectToolStripMenuItem,
            this.chooseBackgroundImageMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileMenuItem.Text = "File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(438, 34);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // createNewProjectToolStripMenuItem
            // 
            this.createNewProjectToolStripMenuItem.Name = "createNewProjectToolStripMenuItem";
            this.createNewProjectToolStripMenuItem.Size = new System.Drawing.Size(438, 34);
            this.createNewProjectToolStripMenuItem.Text = "Create New Project";
            this.createNewProjectToolStripMenuItem.Click += new System.EventHandler(this.createNewProjectToolStripMenuItem_Click);
            // 
            // chooseBackgroundImageMenuItem
            // 
            this.chooseBackgroundImageMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chooseBackgroundImageMenuItem.Name = "chooseBackgroundImageMenuItem";
            this.chooseBackgroundImageMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.chooseBackgroundImageMenuItem.Size = new System.Drawing.Size(438, 34);
            this.chooseBackgroundImageMenuItem.Text = "Choose Background Image";
            this.chooseBackgroundImageMenuItem.Click += new System.EventHandler(this.chooseBackgroundImageMenuItem_Click);
            // 
            // taskListsMenuItem
            // 
            this.taskListsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaskListMenuItem});
            this.taskListsMenuItem.Name = "taskListsMenuItem";
            this.taskListsMenuItem.Size = new System.Drawing.Size(100, 29);
            this.taskListsMenuItem.Text = "Task Lists";
            // 
            // createTaskListMenuItem
            // 
            this.createTaskListMenuItem.Name = "createTaskListMenuItem";
            this.createTaskListMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createTaskListMenuItem.Size = new System.Drawing.Size(259, 34);
            this.createTaskListMenuItem.Text = "Create List";
            this.createTaskListMenuItem.Click += new System.EventHandler(this.createTaskListMenuItem_Click);
            // 
            // fileDialogue
            // 
            this.fileDialogue.FileName = "fileDialogue";
            // 
            // contentLayoutPanel
            // 
            this.contentLayoutPanel.BackColor = System.Drawing.Color.Transparent;
            this.contentLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.contentLayoutPanel.Location = new System.Drawing.Point(0, 33);
            this.contentLayoutPanel.Name = "contentLayoutPanel";
            this.contentLayoutPanel.Size = new System.Drawing.Size(1024, 1003);
            this.contentLayoutPanel.TabIndex = 1;
            // 
            // projectProgressBar
            // 
            this.projectProgressBar.Location = new System.Drawing.Point(783, 4);
            this.projectProgressBar.Name = "projectProgressBar";
            this.projectProgressBar.Size = new System.Drawing.Size(229, 26);
            this.projectProgressBar.TabIndex = 0;
            // 
            // progressLabel
            // 
            this.progressLabel.AutoSize = true;
            this.progressLabel.Location = new System.Drawing.Point(644, 9);
            this.progressLabel.Name = "progressLabel";
            this.progressLabel.Size = new System.Drawing.Size(133, 20);
            this.progressLabel.TabIndex = 2;
            this.progressLabel.Text = "Project Progress: ";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 1036);
            this.Controls.Add(this.progressLabel);
            this.Controls.Add(this.projectProgressBar);
            this.Controls.Add(this.contentLayoutPanel);
            this.Controls.Add(this.menu);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.MainMenuStrip = this.menu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Taskio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openProjectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewProjectToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog fileDialogue;
        private System.Windows.Forms.ToolStripMenuItem taskListsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chooseBackgroundImageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createTaskListMenuItem;
        private System.Windows.Forms.FlowLayoutPanel contentLayoutPanel;
        private System.Windows.Forms.ProgressBar projectProgressBar;
        private System.Windows.Forms.Label progressLabel;
    }
}

