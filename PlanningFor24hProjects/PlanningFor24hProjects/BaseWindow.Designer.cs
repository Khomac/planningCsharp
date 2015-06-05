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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.modifyEmplListButton = new System.Windows.Forms.Button();
            this.languageLabel = new System.Windows.Forms.Label();
            this.calendarModeLabel = new System.Windows.Forms.Label();
            this.workModeLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.datePickerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openCalendarButton
            // 
            this.openCalendarButton.Location = new System.Drawing.Point(383, 101);
            this.openCalendarButton.Name = "openCalendarButton";
            this.openCalendarButton.Size = new System.Drawing.Size(108, 37);
            this.openCalendarButton.TabIndex = 0;
            this.openCalendarButton.Text = "Create Calendar";
            this.openCalendarButton.UseVisualStyleBackColor = true;
            this.openCalendarButton.Click += new System.EventHandler(this.openCalendarButton_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Polski",
            "Francais",
            "English"});
            this.comboBox1.Location = new System.Drawing.Point(34, 50);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "One month",
            "Trimester"});
            this.comboBox4.Location = new System.Drawing.Point(34, 117);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(121, 21);
            this.comboBox4.TabIndex = 4;
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "2/2",
            "3/3",
            "4/4",
            "Random"});
            this.comboBox5.Location = new System.Drawing.Point(209, 50);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(121, 21);
            this.comboBox5.TabIndex = 5;
            // 
            // modifyEmplListButton
            // 
            this.modifyEmplListButton.Location = new System.Drawing.Point(383, 34);
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
            this.workModeLabel.Location = new System.Drawing.Point(206, 34);
            this.workModeLabel.Name = "workModeLabel";
            this.workModeLabel.Size = new System.Drawing.Size(62, 13);
            this.workModeLabel.TabIndex = 11;
            this.workModeLabel.Text = "Work mode";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "MM/yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(209, 114);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(121, 20);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.TabStop = false;
            this.dateTimePicker1.Value = new System.DateTime(2015, 6, 1, 0, 0, 0, 0);
            this.dateTimePicker1.DropDown += new System.EventHandler(this.dateTimePicker1_DropDown);
            // 
            // datePickerLabel
            // 
            this.datePickerLabel.AutoSize = true;
            this.datePickerLabel.Location = new System.Drawing.Point(206, 98);
            this.datePickerLabel.Name = "datePickerLabel";
            this.datePickerLabel.Size = new System.Drawing.Size(58, 13);
            this.datePickerLabel.TabIndex = 13;
            this.datePickerLabel.Text = "First month";
            // 
            // BaseWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(535, 177);
            this.Controls.Add(this.datePickerLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.workModeLabel);
            this.Controls.Add(this.calendarModeLabel);
            this.Controls.Add(this.languageLabel);
            this.Controls.Add(this.modifyEmplListButton);
            this.Controls.Add(this.comboBox5);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.openCalendarButton);
            this.Name = "BaseWindow";
            this.Text = "Settings window";
            this.Load += new System.EventHandler(this.BaseWindow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openCalendarButton;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Button modifyEmplListButton;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Label calendarModeLabel;
        private System.Windows.Forms.Label workModeLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label datePickerLabel;
    }
}

