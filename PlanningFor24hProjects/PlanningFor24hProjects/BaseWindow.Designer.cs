namespace PlanningFor24hProjects
{
    partial class BaseWindow
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
            this.openCalendarButton = new System.Windows.Forms.Button();
            this.languageChoiceComboBox = new System.Windows.Forms.ComboBox();
            this.calendarModeComboBox = new System.Windows.Forms.ComboBox();
            this.workModeComboBox = new System.Windows.Forms.ComboBox();
            this.modifyEmplListButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.calendarModeLabel = new System.Windows.Forms.Label();
            this.workModeLabel = new System.Windows.Forms.Label();
            this.datePickerLabel = new System.Windows.Forms.Label();
            this.dateChoiceButton = new System.Windows.Forms.Button();
            this.chosenDateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openCalendarButton
            // 
            this.openCalendarButton.Location = new System.Drawing.Point(356, 160);
            this.openCalendarButton.Name = "openCalendarButton";
            this.openCalendarButton.Size = new System.Drawing.Size(108, 37);
            this.openCalendarButton.TabIndex = 0;
            this.openCalendarButton.Text = "Create Calendar";
            this.openCalendarButton.UseVisualStyleBackColor = true;
            this.openCalendarButton.Click += new System.EventHandler(this.openCalendarButton_Click);
            // 
            // languageChoiceComboBox
            // 
            this.languageChoiceComboBox.FormattingEnabled = true;
            this.languageChoiceComboBox.Items.AddRange(new object[] {
            "Polski",
            "Francais",
            "English"});
            this.languageChoiceComboBox.Location = new System.Drawing.Point(34, 50);
            this.languageChoiceComboBox.Name = "languageChoiceComboBox";
            this.languageChoiceComboBox.Size = new System.Drawing.Size(121, 21);
            this.languageChoiceComboBox.TabIndex = 1;
            this.languageChoiceComboBox.Text = "English";
            this.languageChoiceComboBox.SelectedIndexChanged += new System.EventHandler(this.languageChoiceCombobox_SelectedIndexChanged);
            // 
            // calendarModeComboBox
            // 
            this.calendarModeComboBox.FormattingEnabled = true;
            this.calendarModeComboBox.Items.AddRange(new object[] {
            "One month",
            "Trimester"});
            this.calendarModeComboBox.Location = new System.Drawing.Point(34, 117);
            this.calendarModeComboBox.Name = "calendarModeComboBox";
            this.calendarModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.calendarModeComboBox.TabIndex = 4;
            // 
            // workModeComboBox
            // 
            this.workModeComboBox.FormattingEnabled = true;
            this.workModeComboBox.Items.AddRange(new object[] {
            "2/2",
            "3/3",
            "4/4",
            "Random"});
            this.workModeComboBox.Location = new System.Drawing.Point(34, 176);
            this.workModeComboBox.Name = "workModeComboBox";
            this.workModeComboBox.Size = new System.Drawing.Size(121, 21);
            this.workModeComboBox.TabIndex = 5;
            // 
            // modifyEmplListButton
            // 
            this.modifyEmplListButton.Location = new System.Drawing.Point(194, 160);
            this.modifyEmplListButton.Name = "modifyEmplListButton";
            this.modifyEmplListButton.Size = new System.Drawing.Size(108, 37);
            this.modifyEmplListButton.TabIndex = 6;
            this.modifyEmplListButton.Text = "Modify employee list";
            this.modifyEmplListButton.UseVisualStyleBackColor = true;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Location = new System.Drawing.Point(34, 34);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(55, 13);
            this.languageLabel.TabIndex = 7;
            this.languageLabel.Text = "Language";
            // 
            // calendarModeLabel
            // 
            this.calendarModeLabel.AutoSize = true;
            this.calendarModeLabel.Location = new System.Drawing.Point(34, 101);
            this.calendarModeLabel.Name = "calendarModeLabel";
            this.calendarModeLabel.Size = new System.Drawing.Size(78, 13);
            this.calendarModeLabel.TabIndex = 8;
            this.calendarModeLabel.Text = "Calendar mode";
            // 
            // workModeLabel
            // 
            this.workModeLabel.AutoSize = true;
            this.workModeLabel.Location = new System.Drawing.Point(31, 160);
            this.workModeLabel.Name = "workModeLabel";
            this.workModeLabel.Size = new System.Drawing.Size(62, 13);
            this.workModeLabel.TabIndex = 11;
            this.workModeLabel.Text = "Work mode";
            // 
            // datePickerLabel
            // 
            this.datePickerLabel.AutoSize = true;
            this.datePickerLabel.Location = new System.Drawing.Point(260, 101);
            this.datePickerLabel.Name = "datePickerLabel";
            this.datePickerLabel.Size = new System.Drawing.Size(58, 13);
            this.datePickerLabel.TabIndex = 13;
            this.datePickerLabel.Text = "First month";
            // 
            // dateChoiceButton
            // 
            this.dateChoiceButton.Location = new System.Drawing.Point(263, 34);
            this.dateChoiceButton.Name = "dateChoiceButton";
            this.dateChoiceButton.Size = new System.Drawing.Size(124, 39);
            this.dateChoiceButton.TabIndex = 14;
            this.dateChoiceButton.Text = "Date choice";
            this.dateChoiceButton.UseVisualStyleBackColor = true;
            // 
            // chosenDateTextBox
            // 
            this.chosenDateTextBox.Location = new System.Drawing.Point(263, 118);
            this.chosenDateTextBox.Name = "chosenDateTextBox";
            this.chosenDateTextBox.ReadOnly = true;
            this.chosenDateTextBox.Size = new System.Drawing.Size(124, 20);
            this.chosenDateTextBox.TabIndex = 15;
            // 
            // BaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(505, 224);
            this.Controls.Add(this.chosenDateTextBox);
            this.Controls.Add(this.dateChoiceButton);
            this.Controls.Add(this.datePickerLabel);
            this.Controls.Add(this.workModeLabel);
            this.Controls.Add(this.calendarModeLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.modifyEmplListButton);
            this.Controls.Add(this.workModeComboBox);
            this.Controls.Add(this.calendarModeComboBox);
            this.Controls.Add(this.languageChoiceComboBox);
            this.Controls.Add(this.openCalendarButton);
            this.Name = "BaseWindow";
            this.Text = "Settings window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openCalendarButton;
        private System.Windows.Forms.ComboBox languageChoiceComboBox;
        private System.Windows.Forms.ComboBox calendarModeComboBox;
        private System.Windows.Forms.ComboBox workModeComboBox;
        private System.Windows.Forms.Button modifyEmplListButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label calendarModeLabel;
        private System.Windows.Forms.Label workModeLabel;
        private System.Windows.Forms.Label datePickerLabel;
        private System.Windows.Forms.Button dateChoiceButton;
        private System.Windows.Forms.TextBox chosenDateTextBox;
    }
}

