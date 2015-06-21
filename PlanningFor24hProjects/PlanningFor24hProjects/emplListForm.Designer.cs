namespace PlanningFor24hProjects
{
    partial class EmplListForm
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
            this.emplListView = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.delateEmplButton = new System.Windows.Forms.Button();
            this.modifyEmplButton = new System.Windows.Forms.Button();
            this.addEmplButton = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.modifyProjectsListButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emplListView
            // 
            this.emplListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.emplListView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.emplListView.GridLines = true;
            this.emplListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.emplListView.Location = new System.Drawing.Point(13, 12);
            this.emplListView.Name = "emplListView";
            this.emplListView.Size = new System.Drawing.Size(913, 355);
            this.emplListView.TabIndex = 0;
            this.emplListView.UseCompatibleStateImageBehavior = false;
            this.emplListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 237;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Workorder preference";
            this.columnHeader3.Width = 118;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Known projects";
            this.columnHeader4.Width = 536;
            // 
            // delateEmplButton
            // 
            this.delateEmplButton.Location = new System.Drawing.Point(332, 373);
            this.delateEmplButton.Name = "delateEmplButton";
            this.delateEmplButton.Size = new System.Drawing.Size(275, 23);
            this.delateEmplButton.TabIndex = 1;
            this.delateEmplButton.Text = "Delate selected";
            this.delateEmplButton.UseVisualStyleBackColor = true;
            // 
            // modifyEmplButton
            // 
            this.modifyEmplButton.Location = new System.Drawing.Point(332, 402);
            this.modifyEmplButton.Name = "modifyEmplButton";
            this.modifyEmplButton.Size = new System.Drawing.Size(275, 23);
            this.modifyEmplButton.TabIndex = 2;
            this.modifyEmplButton.Text = "Modify selected";
            this.modifyEmplButton.UseVisualStyleBackColor = true;
            // 
            // addEmplButton
            // 
            this.addEmplButton.Location = new System.Drawing.Point(13, 373);
            this.addEmplButton.Name = "addEmplButton";
            this.addEmplButton.Size = new System.Drawing.Size(275, 23);
            this.addEmplButton.TabIndex = 3;
            this.addEmplButton.Text = "Add new employee";
            this.addEmplButton.UseVisualStyleBackColor = true;
            this.addEmplButton.Click += new System.EventHandler(this.addEmplButton_Click);
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Location = new System.Drawing.Point(651, 373);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(275, 52);
            this.saveAndCloseButton.TabIndex = 4;
            this.saveAndCloseButton.Text = "Save and close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // modifyProjectsListButton
            // 
            this.modifyProjectsListButton.Location = new System.Drawing.Point(13, 402);
            this.modifyProjectsListButton.Name = "modifyProjectsListButton";
            this.modifyProjectsListButton.Size = new System.Drawing.Size(275, 23);
            this.modifyProjectsListButton.TabIndex = 5;
            this.modifyProjectsListButton.Text = "modifyProjectsListButton";
            this.modifyProjectsListButton.UseVisualStyleBackColor = true;
            this.modifyProjectsListButton.Click += new System.EventHandler(this.modifyProjectsListButton_Click);
            // 
            // EmplListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 440);
            this.Controls.Add(this.modifyProjectsListButton);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.addEmplButton);
            this.Controls.Add(this.modifyEmplButton);
            this.Controls.Add(this.delateEmplButton);
            this.Controls.Add(this.emplListView);
            this.Name = "EmplListForm";
            this.Text = "emplListForm";
            this.Load += new System.EventHandler(this.emplListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView emplListView;
        private System.Windows.Forms.Button delateEmplButton;
        private System.Windows.Forms.Button modifyEmplButton;
        private System.Windows.Forms.Button addEmplButton;
        private System.Windows.Forms.Button saveAndCloseButton;
        private System.Windows.Forms.Button modifyProjectsListButton;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}