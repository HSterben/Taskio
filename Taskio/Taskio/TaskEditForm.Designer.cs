namespace Taskio
{
    partial class TaskEditForm
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
            this.editBtn = new System.Windows.Forms.Button();
            this.priority = new System.Windows.Forms.NumericUpDown();
            this.descriptionText = new System.Windows.Forms.TextBox();
            this.nameText = new System.Windows.Forms.TextBox();
            this.priorityLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.categoryTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.priority)).BeginInit();
            this.SuspendLayout();
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(283, 323);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(150, 35);
            this.editBtn.TabIndex = 13;
            this.editBtn.Text = "Save Changes";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // priority
            // 
            this.priority.Location = new System.Drawing.Point(162, 211);
            this.priority.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.priority.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.priority.Name = "priority";
            this.priority.ReadOnly = true;
            this.priority.Size = new System.Drawing.Size(150, 26);
            this.priority.TabIndex = 12;
            // 
            // descriptionText
            // 
            this.descriptionText.Location = new System.Drawing.Point(162, 83);
            this.descriptionText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.descriptionText.Multiline = true;
            this.descriptionText.Name = "descriptionText";
            this.descriptionText.Size = new System.Drawing.Size(271, 116);
            this.descriptionText.TabIndex = 11;
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(162, 32);
            this.nameText.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(271, 26);
            this.nameText.TabIndex = 10;
            // 
            // priorityLabel
            // 
            this.priorityLabel.AutoSize = true;
            this.priorityLabel.Location = new System.Drawing.Point(38, 211);
            this.priorityLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.priorityLabel.Name = "priorityLabel";
            this.priorityLabel.Size = new System.Drawing.Size(56, 20);
            this.priorityLabel.TabIndex = 9;
            this.priorityLabel.Text = "Priority";
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(38, 88);
            this.descriptionLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(97, 20);
            this.descriptionLabel.TabIndex = 8;
            this.descriptionLabel.Text = "Description: ";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(38, 37);
            this.nameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(97, 20);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "Task Name: ";
            // 
            // deleteBtn
            // 
            this.deleteBtn.ForeColor = System.Drawing.Color.IndianRed;
            this.deleteBtn.Location = new System.Drawing.Point(40, 323);
            this.deleteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(150, 35);
            this.deleteBtn.TabIndex = 14;
            this.deleteBtn.Text = "Delete Task";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // categoryTextBox
            // 
            this.categoryTextBox.Location = new System.Drawing.Point(162, 262);
            this.categoryTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.categoryTextBox.Name = "categoryTextBox";
            this.categoryTextBox.Size = new System.Drawing.Size(271, 26);
            this.categoryTextBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 267);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Task Category: ";
            // 
            // TaskEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 384);
            this.Controls.Add(this.categoryTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.priority);
            this.Controls.Add(this.descriptionText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.priorityLabel);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.nameLabel);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "TaskEditForm";
            this.Text = "Edit Task";
            ((System.ComponentModel.ISupportInitialize)(this.priority)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.NumericUpDown priority;
        private System.Windows.Forms.TextBox descriptionText;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label priorityLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.TextBox categoryTextBox;
        private System.Windows.Forms.Label label1;
    }
}