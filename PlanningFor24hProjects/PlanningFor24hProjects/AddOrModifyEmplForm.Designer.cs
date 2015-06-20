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
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.saveAndExitButton = new System.Windows.Forms.Button();
            this.knownProjectsListCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.workorderPreferencesComboBox = new System.Windows.Forms.Label();
            this.knownProjectsListLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(37, 28);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(309, 20);
            this.surnameTextBox.TabIndex = 0;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(37, 71);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(309, 20);
            this.textBox3.TabIndex = 2;
            // 
            // saveAndExitButton
            // 
            this.saveAndExitButton.Location = new System.Drawing.Point(37, 415);
            this.saveAndExitButton.Name = "saveAndExitButton";
            this.saveAndExitButton.Size = new System.Drawing.Size(309, 23);
            this.saveAndExitButton.TabIndex = 3;
            this.saveAndExitButton.Text = "saveAndExitButton";
            this.saveAndExitButton.UseVisualStyleBackColor = true;
            this.saveAndExitButton.Click += new System.EventHandler(this.saveAndExitButton_Click);
            // 
            // knownProjectsListCheckedListBox
            // 
            this.knownProjectsListCheckedListBox.FormattingEnabled = true;
            this.knownProjectsListCheckedListBox.Location = new System.Drawing.Point(37, 175);
            this.knownProjectsListCheckedListBox.MultiColumn = true;
            this.knownProjectsListCheckedListBox.Name = "knownProjectsListCheckedListBox";
            this.knownProjectsListCheckedListBox.Size = new System.Drawing.Size(309, 214);
            this.knownProjectsListCheckedListBox.TabIndex = 4;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(37, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(309, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(34, 12);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(73, 13);
            this.surnameLabel.TabIndex = 6;
            this.surnameLabel.Text = "surnameLabel";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(34, 55);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(59, 13);
            this.nameLabel.TabIndex = 7;
            this.nameLabel.Text = "nameLabel";
            // 
            // workorderPreferencesComboBox
            // 
            this.workorderPreferencesComboBox.AutoSize = true;
            this.workorderPreferencesComboBox.Location = new System.Drawing.Point(34, 96);
            this.workorderPreferencesComboBox.Name = "workorderPreferencesComboBox";
            this.workorderPreferencesComboBox.Size = new System.Drawing.Size(162, 13);
            this.workorderPreferencesComboBox.TabIndex = 8;
            this.workorderPreferencesComboBox.Text = "workorderPreferencesComboBox";
            // 
            // knownProjectsListLabel
            // 
            this.knownProjectsListLabel.AutoSize = true;
            this.knownProjectsListLabel.Location = new System.Drawing.Point(34, 159);
            this.knownProjectsListLabel.Name = "knownProjectsListLabel";
            this.knownProjectsListLabel.Size = new System.Drawing.Size(119, 13);
            this.knownProjectsListLabel.TabIndex = 9;
            this.knownProjectsListLabel.Text = "knownProjectsListLabel";
            // 
            // AddOrModifyEmplForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 461);
            this.Controls.Add(this.knownProjectsListLabel);
            this.Controls.Add(this.workorderPreferencesComboBox);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.knownProjectsListCheckedListBox);
            this.Controls.Add(this.saveAndExitButton);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.surnameTextBox);
            this.Name = "AddOrModifyEmplForm";
            this.Text = "AddOrModifyEmplForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button saveAndExitButton;
        private System.Windows.Forms.CheckedListBox knownProjectsListCheckedListBox;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label workorderPreferencesComboBox;
        private System.Windows.Forms.Label knownProjectsListLabel;
    }
}