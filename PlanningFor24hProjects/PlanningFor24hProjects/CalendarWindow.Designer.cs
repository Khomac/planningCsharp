namespace PlanningFor24hProjects
{
    partial class CalendarWindow
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
            this.calendarField = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.monthAndYearLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.shiftTypeBox = new System.Windows.Forms.GroupBox();
            this.hoursNumberLabel = new System.Windows.Forms.Label();
            this.hoursNumberComboBox = new System.Windows.Forms.ComboBox();
            this.emptyRadioButton = new System.Windows.Forms.RadioButton();
            this.sicknessRadioButton = new System.Windows.Forms.RadioButton();
            this.holidayRadioButton = new System.Windows.Forms.RadioButton();
            this.nightRadioButton = new System.Windows.Forms.RadioButton();
            this.dayRadioButton = new System.Windows.Forms.RadioButton();
            this.createCalendarButton = new System.Windows.Forms.Button();
            this.exportCalendarButton = new System.Windows.Forms.Button();
            this.clearCalendarButton = new System.Windows.Forms.Button();
            this.shiftTypeBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calendarField
            // 
            this.calendarField.Alignment = System.Windows.Forms.ListViewAlignment.Left;
            this.calendarField.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.calendarField.Cursor = System.Windows.Forms.Cursors.Hand;
            this.calendarField.GridLines = true;
            this.calendarField.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.calendarField.Location = new System.Drawing.Point(177, 33);
            this.calendarField.Name = "calendarField";
            this.calendarField.OwnerDraw = true;
            this.calendarField.Size = new System.Drawing.Size(924, 346);
            this.calendarField.TabIndex = 0;
            this.calendarField.UseCompatibleStateImageBehavior = false;
            this.calendarField.View = System.Windows.Forms.View.Details;
            this.calendarField.DrawColumnHeader += new System.Windows.Forms.DrawListViewColumnHeaderEventHandler(this.CalendarField_DrawColumnHeader);
            this.calendarField.DrawSubItem += new System.Windows.Forms.DrawListViewSubItemEventHandler(this.calendarField_DrawSubItem);
            this.calendarField.MouseDown += new System.Windows.Forms.MouseEventHandler(this.calendarField_MouseDown);
            this.calendarField.MouseUp += new System.Windows.Forms.MouseEventHandler(this.calendarField_MouseUp);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Imię i Nazwisko";
            this.columnHeader1.Width = 249;
            // 
            // monthAndYearLabel
            // 
            this.monthAndYearLabel.AutoSize = true;
            this.monthAndYearLabel.Location = new System.Drawing.Point(174, 17);
            this.monthAndYearLabel.Name = "monthAndYearLabel";
            this.monthAndYearLabel.Size = new System.Drawing.Size(65, 13);
            this.monthAndYearLabel.TabIndex = 1;
            this.monthAndYearLabel.Text = "miesiac i rok";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1124, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(187, 346);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(177, 417);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(924, 92);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // shiftTypeBox
            // 
            this.shiftTypeBox.Controls.Add(this.hoursNumberLabel);
            this.shiftTypeBox.Controls.Add(this.hoursNumberComboBox);
            this.shiftTypeBox.Controls.Add(this.emptyRadioButton);
            this.shiftTypeBox.Controls.Add(this.sicknessRadioButton);
            this.shiftTypeBox.Controls.Add(this.holidayRadioButton);
            this.shiftTypeBox.Controls.Add(this.nightRadioButton);
            this.shiftTypeBox.Controls.Add(this.dayRadioButton);
            this.shiftTypeBox.Location = new System.Drawing.Point(19, 33);
            this.shiftTypeBox.Name = "shiftTypeBox";
            this.shiftTypeBox.Size = new System.Drawing.Size(134, 211);
            this.shiftTypeBox.TabIndex = 4;
            this.shiftTypeBox.TabStop = false;
            this.shiftTypeBox.Text = "Rodzaj Zmiany";
            // 
            // hoursNumberLabel
            // 
            this.hoursNumberLabel.AutoSize = true;
            this.hoursNumberLabel.Location = new System.Drawing.Point(27, 158);
            this.hoursNumberLabel.Name = "hoursNumberLabel";
            this.hoursNumberLabel.Size = new System.Drawing.Size(85, 13);
            this.hoursNumberLabel.TabIndex = 6;
            this.hoursNumberLabel.Text = "Number of hours";
            // 
            // hoursNumberComboBox
            // 
            this.hoursNumberComboBox.FormattingEnabled = true;
            this.hoursNumberComboBox.ItemHeight = 13;
            this.hoursNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.hoursNumberComboBox.Location = new System.Drawing.Point(41, 177);
            this.hoursNumberComboBox.MaxDropDownItems = 12;
            this.hoursNumberComboBox.Name = "hoursNumberComboBox";
            this.hoursNumberComboBox.Size = new System.Drawing.Size(52, 21);
            this.hoursNumberComboBox.TabIndex = 5;
            this.hoursNumberComboBox.Text = "12";
            // 
            // emptyRadioButton
            // 
            this.emptyRadioButton.AutoSize = true;
            this.emptyRadioButton.Location = new System.Drawing.Point(27, 124);
            this.emptyRadioButton.Name = "emptyRadioButton";
            this.emptyRadioButton.Size = new System.Drawing.Size(52, 17);
            this.emptyRadioButton.TabIndex = 4;
            this.emptyRadioButton.Text = "Pusto";
            this.emptyRadioButton.UseVisualStyleBackColor = true;
            // 
            // sicknessRadioButton
            // 
            this.sicknessRadioButton.AutoSize = true;
            this.sicknessRadioButton.Location = new System.Drawing.Point(27, 100);
            this.sicknessRadioButton.Name = "sicknessRadioButton";
            this.sicknessRadioButton.Size = new System.Drawing.Size(37, 17);
            this.sicknessRadioButton.TabIndex = 3;
            this.sicknessRadioButton.Text = "L4";
            this.sicknessRadioButton.UseVisualStyleBackColor = true;
            // 
            // holidayRadioButton
            // 
            this.holidayRadioButton.AutoSize = true;
            this.holidayRadioButton.Checked = true;
            this.holidayRadioButton.Location = new System.Drawing.Point(27, 77);
            this.holidayRadioButton.Name = "holidayRadioButton";
            this.holidayRadioButton.Size = new System.Drawing.Size(50, 17);
            this.holidayRadioButton.TabIndex = 2;
            this.holidayRadioButton.TabStop = true;
            this.holidayRadioButton.Text = "Urlop";
            this.holidayRadioButton.UseVisualStyleBackColor = true;
            // 
            // nightRadioButton
            // 
            this.nightRadioButton.AutoSize = true;
            this.nightRadioButton.Location = new System.Drawing.Point(27, 54);
            this.nightRadioButton.Name = "nightRadioButton";
            this.nightRadioButton.Size = new System.Drawing.Size(45, 17);
            this.nightRadioButton.TabIndex = 1;
            this.nightRadioButton.Text = "Noc";
            this.nightRadioButton.UseVisualStyleBackColor = true;
            // 
            // dayRadioButton
            // 
            this.dayRadioButton.AutoSize = true;
            this.dayRadioButton.Location = new System.Drawing.Point(27, 31);
            this.dayRadioButton.Name = "dayRadioButton";
            this.dayRadioButton.Size = new System.Drawing.Size(52, 17);
            this.dayRadioButton.TabIndex = 0;
            this.dayRadioButton.Text = "Dzien";
            this.dayRadioButton.UseVisualStyleBackColor = true;
            // 
            // createCalendarButton
            // 
            this.createCalendarButton.Location = new System.Drawing.Point(19, 274);
            this.createCalendarButton.Name = "createCalendarButton";
            this.createCalendarButton.Size = new System.Drawing.Size(134, 105);
            this.createCalendarButton.TabIndex = 5;
            this.createCalendarButton.Text = "Fill calendar automatically";
            this.createCalendarButton.UseVisualStyleBackColor = true;
            // 
            // exportCalendarButton
            // 
            this.exportCalendarButton.Location = new System.Drawing.Point(1124, 417);
            this.exportCalendarButton.Name = "exportCalendarButton";
            this.exportCalendarButton.Size = new System.Drawing.Size(187, 92);
            this.exportCalendarButton.TabIndex = 6;
            this.exportCalendarButton.Text = "Export";
            this.exportCalendarButton.UseVisualStyleBackColor = true;
            // 
            // clearCalendarButton
            // 
            this.clearCalendarButton.Location = new System.Drawing.Point(19, 417);
            this.clearCalendarButton.Name = "clearCalendarButton";
            this.clearCalendarButton.Size = new System.Drawing.Size(134, 54);
            this.clearCalendarButton.TabIndex = 7;
            this.clearCalendarButton.Text = "Clear";
            this.clearCalendarButton.UseVisualStyleBackColor = true;
            this.clearCalendarButton.Click += new System.EventHandler(this.clearCalendarButton_Click);
            // 
            // CalendarWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 528);
            this.Controls.Add(this.clearCalendarButton);
            this.Controls.Add(this.exportCalendarButton);
            this.Controls.Add(this.createCalendarButton);
            this.Controls.Add(this.shiftTypeBox);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.monthAndYearLabel);
            this.Controls.Add(this.calendarField);
            this.Name = "CalendarWindow";
            this.Text = "CalendarWindow";
            this.Load += new System.EventHandler(this.CalendarWindow_Load);
            this.shiftTypeBox.ResumeLayout(false);
            this.shiftTypeBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView calendarField;
        private System.Windows.Forms.Label monthAndYearLabel;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.GroupBox shiftTypeBox;
        private System.Windows.Forms.RadioButton sicknessRadioButton;
        private System.Windows.Forms.RadioButton nightRadioButton;
        private System.Windows.Forms.RadioButton dayRadioButton;
        private System.Windows.Forms.RadioButton emptyRadioButton;
        private System.Windows.Forms.RadioButton holidayRadioButton;
        private System.Windows.Forms.Button createCalendarButton;
        private System.Windows.Forms.Button exportCalendarButton;
        private System.Windows.Forms.Button clearCalendarButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label hoursNumberLabel;
        private System.Windows.Forms.ComboBox hoursNumberComboBox;

    }
}