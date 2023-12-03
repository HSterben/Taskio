namespace Taskio
{
    partial class UtilityForm
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
            this.sortByPriorityButton = new System.Windows.Forms.Button();
            this.sortByNameButton = new System.Windows.Forms.Button();
            this.newTaskNameTextBox = new System.Windows.Forms.TextBox();
            this.newnameLabel = new System.Windows.Forms.Label();
            this.TaskNameUpdateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // sortByPriorityButton
            // 
            this.sortByPriorityButton.Location = new System.Drawing.Point(194, 79);
            this.sortByPriorityButton.Name = "sortByPriorityButton";
            this.sortByPriorityButton.Size = new System.Drawing.Size(143, 35);
            this.sortByPriorityButton.TabIndex = 0;
            this.sortByPriorityButton.Text = "Sort by Priority";
            this.sortByPriorityButton.UseVisualStyleBackColor = true;
            this.sortByPriorityButton.Click += new System.EventHandler(this.sortByPriorityButton_Click);
            // 
            // sortByNameButton
            // 
            this.sortByNameButton.Location = new System.Drawing.Point(12, 79);
            this.sortByNameButton.Name = "sortByNameButton";
            this.sortByNameButton.Size = new System.Drawing.Size(176, 35);
            this.sortByNameButton.TabIndex = 1;
            this.sortByNameButton.Text = "Sort Alphabetically";
            this.sortByNameButton.UseVisualStyleBackColor = true;
            this.sortByNameButton.Click += new System.EventHandler(this.sortByNameButton_Click);
            // 
            // newTaskNameTextBox
            // 
            this.newTaskNameTextBox.Location = new System.Drawing.Point(142, 6);
            this.newTaskNameTextBox.Name = "newTaskNameTextBox";
            this.newTaskNameTextBox.Size = new System.Drawing.Size(195, 26);
            this.newTaskNameTextBox.TabIndex = 2;
            // 
            // newnameLabel
            // 
            this.newnameLabel.AutoSize = true;
            this.newnameLabel.Location = new System.Drawing.Point(8, 9);
            this.newnameLabel.Name = "newnameLabel";
            this.newnameLabel.Size = new System.Drawing.Size(128, 20);
            this.newnameLabel.TabIndex = 3;
            this.newnameLabel.Text = "New Task Name:";
            // 
            // TaskNameUpdateButton
            // 
            this.TaskNameUpdateButton.Location = new System.Drawing.Point(77, 38);
            this.TaskNameUpdateButton.Name = "TaskNameUpdateButton";
            this.TaskNameUpdateButton.Size = new System.Drawing.Size(188, 35);
            this.TaskNameUpdateButton.TabIndex = 4;
            this.TaskNameUpdateButton.Text = "Update TaskList Name";
            this.TaskNameUpdateButton.UseVisualStyleBackColor = true;
            this.TaskNameUpdateButton.Click += new System.EventHandler(this.TaskNameUpdateButton_Click);
            // 
            // UtilityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 123);
            this.Controls.Add(this.TaskNameUpdateButton);
            this.Controls.Add(this.newnameLabel);
            this.Controls.Add(this.newTaskNameTextBox);
            this.Controls.Add(this.sortByNameButton);
            this.Controls.Add(this.sortByPriorityButton);
            this.Name = "UtilityForm";
            this.Text = "UtilityForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sortByPriorityButton;
        private System.Windows.Forms.Button sortByNameButton;
        private System.Windows.Forms.TextBox newTaskNameTextBox;
        private System.Windows.Forms.Label newnameLabel;
        private System.Windows.Forms.Button TaskNameUpdateButton;
    }
}