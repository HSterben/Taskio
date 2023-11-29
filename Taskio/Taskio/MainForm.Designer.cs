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
            this.projectOverviewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tasksMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortingOptionsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nameSortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dueDateSortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prioritySortMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkModeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.tasksMenuItem,
            this.modeMenuItem});
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
            this.projectOverviewToolStripMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileMenuItem.Text = "File";
            // 
            // openProjectToolStripMenuItem
            // 
            this.openProjectToolStripMenuItem.Name = "openProjectToolStripMenuItem";
            this.openProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openProjectToolStripMenuItem.Text = "Open Project";
            // 
            // createNewProjectToolStripMenuItem
            // 
            this.createNewProjectToolStripMenuItem.Name = "createNewProjectToolStripMenuItem";
            this.createNewProjectToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.createNewProjectToolStripMenuItem.Text = "Create New Project";
            // 
            // projectOverviewToolStripMenuItem
            // 
            this.projectOverviewToolStripMenuItem.Name = "projectOverviewToolStripMenuItem";
            this.projectOverviewToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.projectOverviewToolStripMenuItem.Text = "Project Overview";
            // 
            // tasksMenuItem
            // 
            this.tasksMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sortingOptionsMenuItem});
            this.tasksMenuItem.Name = "tasksMenuItem";
            this.tasksMenuItem.Size = new System.Drawing.Size(47, 20);
            this.tasksMenuItem.Text = "Tasks";
            // 
            // sortingOptionsMenuItem
            // 
            this.sortingOptionsMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nameSortMenuItem,
            this.dueDateSortMenuItem,
            this.prioritySortMenuItem});
            this.sortingOptionsMenuItem.Name = "sortingOptionsMenuItem";
            this.sortingOptionsMenuItem.Size = new System.Drawing.Size(180, 22);
            this.sortingOptionsMenuItem.Text = "Sort By";
            // 
            // nameSortMenuItem
            // 
            this.nameSortMenuItem.Name = "nameSortMenuItem";
            this.nameSortMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nameSortMenuItem.Text = "Name";
            // 
            // dueDateSortMenuItem
            // 
            this.dueDateSortMenuItem.Name = "dueDateSortMenuItem";
            this.dueDateSortMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dueDateSortMenuItem.Text = "Due Date";
            // 
            // prioritySortMenuItem
            // 
            this.prioritySortMenuItem.Name = "prioritySortMenuItem";
            this.prioritySortMenuItem.Size = new System.Drawing.Size(180, 22);
            this.prioritySortMenuItem.Text = "Priority";
            // 
            // modeMenuItem
            // 
            this.modeMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lightModeMenuItem,
            this.darkModeMenuItem});
            this.modeMenuItem.Name = "modeMenuItem";
            this.modeMenuItem.Size = new System.Drawing.Size(50, 20);
            this.modeMenuItem.Text = "Mode";
            // 
            // lightModeMenuItem
            // 
            this.lightModeMenuItem.Checked = true;
            this.lightModeMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.lightModeMenuItem.Name = "lightModeMenuItem";
            this.lightModeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightModeMenuItem.Text = "Light";
            // 
            // darkModeMenuItem
            // 
            this.darkModeMenuItem.Checked = true;
            this.darkModeMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.darkModeMenuItem.Name = "darkModeMenuItem";
            this.darkModeMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkModeMenuItem.Text = "Dark";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menu);
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
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem projectOverviewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tasksMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sortingOptionsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nameSortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dueDateSortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prioritySortMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightModeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkModeMenuItem;
    }
}

