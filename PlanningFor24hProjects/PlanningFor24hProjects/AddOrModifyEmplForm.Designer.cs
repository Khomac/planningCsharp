namespace PlanningFor24hProjects
{
    partial class AddOrModifyEmplForm
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
            this.NameAndSurnameTextBox = new System.Windows.Forms.TextBox();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.knownProjectsListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.NameAndSurnameLabel = new System.Windows.Forms.Label();
            this.workorderPreferencesComboBox = new System.Windows.Forms.Label();
            this.knownProjectsListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // NameAndSurnameTextBox
            // 
            this.NameAndSurnameTextBox.Location = new System.Drawing.Point(37, 28);
            this.NameAndSurnameTextBox.Name = "NameAndSurnameTextBox";
            this.NameAndSurnameTextBox.Size = new System.Drawing.Size(206, 20);
            this.NameAndSurnameTextBox.TabIndex = 0;
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Location = new System.Drawing.Point(37, 387);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(206, 23);
            this.saveAndExitButton.TabIndex = 3;
            this.saveAndExitButton.Text = "saveAndExitButton";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // knownProjectsListCheckedListBox
            // 
            this.knownProjectsListCheckedListBox.FormattingEnabled = true;
            this.knownProjectsListCheckedListBox.Items.AddRange(new object[] {
            "projekt1",
            "projekt1 szkolenie",
            "projekt2",
            "projekt2 szkolenie"});
            this.knownProjectsListCheckedListBox.Location = new System.Drawing.Point(37, 147);
            this.knownProjectsListCheckedListBox.MultiColumn = true;
            this.knownProjectsListCheckedListBox.Name = "knownProjectsListCheckedListBox";
            this.knownProjectsListCheckedListBox.Size = new System.Drawing.Size(206, 214);
            this.knownProjectsListCheckedListBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "2/2",
            "3/3",
            "4/4",
            "Random"});
            this.comboBox1.Location = new System.Drawing.Point(37, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(206, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // NameAndSurnameLabel
            // 
            this.NameAndSurnameLabel.AutoSize = true;
            this.NameAndSurnameLabel.Location = new System.Drawing.Point(34, 12);
            this.NameAndSurnameLabel.Name = "NameAndSurnameLabel";
            this.NameAndSurnameLabel.Size = new System.Drawing.Size(122, 13);
            this.NameAndSurnameLabel.TabIndex = 6;
            this.NameAndSurnameLabel.Text = "NameAndSurnameLabel";
            // 
            // workorderPreferencesComboBox
            // 
            this.workorderPreferencesComboBox.AutoSize = true;
            this.workorderPreferencesComboBox.Location = new System.Drawing.Point(34, 68);
            this.workorderPreferencesComboBox.Name = "workorderPreferencesComboBox";
            this.workorderPreferencesComboBox.Size = new System.Drawing.Size(162, 13);
            this.workorderPreferencesComboBox.TabIndex = 8;
            this.workorderPreferencesComboBox.Text = "workorderPreferencesComboBox";
            // 
            // knownProjectsListLabel
            // 
            this.knownProjectsListLabel.AutoSize = true;
            this.knownProjectsListLabel.Location = new System.Drawing.Point(34, 131);
            this.knownProjectsListLabel.Name = "knownProjectsListLabel";
            this.knownProjectsListLabel.Size = new System.Drawing.Size(119, 13);
            this.knownProjectsListLabel.TabIndex = 9;
            this.knownProjectsListLabel.Text = "knownProjectsListLabel";
            // 
            // AddOrModifyEmplForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 444);
            this.Controls.Add(this.knownProjectsListLabel);
            this.Controls.Add(this.workorderPreferencesComboBox);
            this.Controls.Add(this.NameAndSurnameLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.knownProjectsListCheckedListBox);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.NameAndSurnameTextBox);
            this.Name = "AddOrModifyEmplForm";
            this.Text = "AddOrModifyEmplForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameAndSurnameTextBox;
        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.CheckedListBox knownProjectsListCheckedListBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label NameAndSurnameLabel;
        private System.Windows.Forms.Label workorderPreferencesComboBox;
        private System.Windows.Forms.Label knownProjectsListLabel;
    }
}