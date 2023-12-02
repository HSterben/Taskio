namespace Taskio
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
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.taskListsMenuItem});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(800, 24);
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
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            this.openProjectToolStripMenuItem.Click += new System.EventHandler(this.openProjectToolStripMenuItem_Click);
            // 
            // createNewProjectToolStripMenuItem
            // 
            this.createNewProjectToolStripMenuItem.Name = "createNewProjectToolStripMenuItem";
            this.createNewProjectToolStripMenuItem.Size = new System.Drawing.Size(290, 22);
            this.createNewProjectToolStripMenuItem.Text = "Create New Project";
            this.createNewProjectToolStripMenuItem.Click += new System.EventHandler(this.createNewProjectToolStripMenuItem_Click);
            // 
            // chooseBackgroundImageMenuItem
            // 
            this.chooseBackgroundImageMenuItem.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.chooseBackgroundImageMenuItem.Name = "chooseBackgroundImageMenuItem";
            this.chooseBackgroundImageMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.B)));
            this.chooseBackgroundImageMenuItem.Size = new System.Drawing.Size(290, 22);
            this.chooseBackgroundImageMenuItem.Text = "Choose Background Image";
            this.chooseBackgroundImageMenuItem.Click += new System.EventHandler(this.chooseBackgroundImageMenuItem_Click);
            // 
            // taskListsMenuItem
            // 
            this.taskListsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createTaskListMenuItem});
            this.taskListsMenuItem.Name = "taskListsMenuItem";
            this.taskListsMenuItem.Size = new System.Drawing.Size(67, 20);
            this.taskListsMenuItem.Text = "Task Lists";
            // 
            // createTaskListMenuItem
            // 
            this.createTaskListMenuItem.Name = "createTaskListMenuItem";
            this.createTaskListMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createTaskListMenuItem.Size = new System.Drawing.Size(172, 22);
            this.createTaskListMenuItem.Text = "Create List";
            this.createTaskListMenuItem.Click += new System.EventHandler(this.createTaskListMenuItem_Click);
            // 
            // fileDialogue
            // 
            this.fileDialogue.FileName = "fileDialogue";
            // 
            // mainPanel
            // 
            this.mainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mainPanel.BackgroundImage")));
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(0, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(800, 426);
            this.mainPanel.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menu;
            this.Name = "MainForm";
            this.Text = "Taskio";
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
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.ToolStripMenuItem createTaskListMenuItem;
    }
}

