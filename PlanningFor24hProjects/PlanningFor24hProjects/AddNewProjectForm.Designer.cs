namespace PlanningFor24hProjects
{
    partial class AddNewProjectForm
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
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectNameTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Location = new System.Drawing.Point(12, 51);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(301, 23);
            this.saveAndCloseButton.TabIndex = 0;
            this.saveAndCloseButton.Text = "saveAndCloseButton";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.AutoSize = true;
            this.projectNameLabel.Location = new System.Drawing.Point(9, 9);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(93, 13);
            this.projectNameLabel.TabIndex = 1;
            this.projectNameLabel.Text = "projectNameLabel";
            // 
            // projectNameTextBox
            // 
            this.projectNameTextBox.Location = new System.Drawing.Point(12, 25);
            this.projectNameTextBox.Name = "projectNameTextBox";
            this.projectNameTextBox.Size = new System.Drawing.Size(301, 20);
            this.projectNameTextBox.TabIndex = 2;
            // 
            // AddNewProjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 88);
            this.Controls.Add(this.projectNameTextBox);
            this.Controls.Add(this.projectNameLabel);
            this.Controls.Add(this.saveAndCloseButton);
            this.Name = "AddNewProjectForm";
            this.Text = "AddNewProjectForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox projectNameTextBox;
    }
}