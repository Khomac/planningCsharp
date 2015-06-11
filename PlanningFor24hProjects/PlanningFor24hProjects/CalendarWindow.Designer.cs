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
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton4 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
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
            this.calendarField.Location = new System.Drawing.Point(206, 33);
            this.calendarField.Name = "calendarField";
            this.calendarField.OwnerDraw = true;
            this.calendarField.Size = new System.Drawing.Size(832, 346);
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
            this.columnHeader1.Width = 200;
            // 
            // monthAndYearLabel
            // 
            this.monthAndYearLabel.AutoSize = true;
            this.monthAndYearLabel.Location = new System.Drawing.Point(203, 17);
            this.monthAndYearLabel.Name = "monthAndYearLabel";
            this.monthAndYearLabel.Size = new System.Drawing.Size(65, 13);
            this.monthAndYearLabel.TabIndex = 1;
            this.monthAndYearLabel.Text = "miesiac i rok";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(1086, 33);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(187, 346);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(206, 417);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(831, 92);
            this.listView2.TabIndex = 3;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // shiftTypeBox
            // 
            this.shiftTypeBox.Controls.Add(this.radioButton5);
            this.shiftTypeBox.Controls.Add(this.radioButton4);
            this.shiftTypeBox.Controls.Add(this.radioButton3);
            this.shiftTypeBox.Controls.Add(this.radioButton2);
            this.shiftTypeBox.Controls.Add(this.radioButton1);
            this.shiftTypeBox.Location = new System.Drawing.Point(19, 33);
            this.shiftTypeBox.Name = "shiftTypeBox";
            this.shiftTypeBox.Size = new System.Drawing.Size(134, 173);
            this.shiftTypeBox.TabIndex = 4;
            this.shiftTypeBox.TabStop = false;
            this.shiftTypeBox.Text = "Rodzaj Zmiany";
            // 
            // radioButton5
            // 
            this.radioButton5.AutoSize = true;
            this.radioButton5.Location = new System.Drawing.Point(27, 124);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(52, 17);
            this.radioButton5.TabIndex = 4;
            this.radioButton5.Text = "Pusto";
            this.radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(27, 100);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(37, 17);
            this.radioButton4.TabIndex = 3;
            this.radioButton4.Text = "L4";
            this.radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Checked = true;
            this.radioButton3.Location = new System.Drawing.Point(27, 77);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(50, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Urlop";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(27, 54);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(45, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Noc";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(27, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(52, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.Text = "Dzien";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // createCalendarButton
            // 
            this.createCalendarButton.Location = new System.Drawing.Point(19, 247);
            this.createCalendarButton.Name = "createCalendarButton";
            this.createCalendarButton.Size = new System.Drawing.Size(134, 132);
            this.createCalendarButton.TabIndex = 5;
            this.createCalendarButton.Text = "Fill calendar automatically";
            this.createCalendarButton.UseVisualStyleBackColor = true;
            // 
            // exportCalendarButton
            // 
            this.exportCalendarButton.Location = new System.Drawing.Point(1086, 417);
            this.exportCalendarButton.Name = "exportCalendarButton";
            this.exportCalendarButton.Size = new System.Drawing.Size(187, 92);
            this.exportCalendarButton.TabIndex = 6;
            this.exportCalendarButton.Text = "Export calendar";
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
            this.ClientSize = new System.Drawing.Size(1297, 528);
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
        private System.Windows.Forms.RadioButton radioButton4;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.Button createCalendarButton;
        private System.Windows.Forms.Button exportCalendarButton;
        private System.Windows.Forms.Button clearCalendarButton;
        private System.Windows.Forms.ColumnHeader columnHeader1;

    }
}