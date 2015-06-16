namespace PlanningFor24hProjects
{
    partial class emplListForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.delateEmplButton = new System.Windows.Forms.Button();
            this.modifyEmplButton = new System.Windows.Forms.Button();
            this.addEmplButton = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(914, 355);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // delateEmplButton
            // 
            this.delateEmplButton.Location = new System.Drawing.Point(12, 373);
            this.delateEmplButton.Name = "delateEmplButton";
            this.delateEmplButton.Size = new System.Drawing.Size(224, 23);
            this.delateEmplButton.TabIndex = 1;
            this.delateEmplButton.Text = "Delate selected";
            this.delateEmplButton.UseVisualStyleBackColor = true;
            // 
            // modifyEmplButton
            // 
            this.modifyEmplButton.Location = new System.Drawing.Point(242, 373);
            this.modifyEmplButton.Name = "modifyEmplButton";
            this.modifyEmplButton.Size = new System.Drawing.Size(224, 23);
            this.modifyEmplButton.TabIndex = 2;
            this.modifyEmplButton.Text = "Modify selected";
            this.modifyEmplButton.UseVisualStyleBackColor = true;
            // 
            // addEmplButton
            // 
            this.addEmplButton.Location = new System.Drawing.Point(472, 373);
            this.addEmplButton.Name = "addEmplButton";
            this.addEmplButton.Size = new System.Drawing.Size(224, 23);
            this.addEmplButton.TabIndex = 3;
            this.addEmplButton.Text = "Add new employee";
            this.addEmplButton.UseVisualStyleBackColor = true;
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Location = new System.Drawing.Point(702, 373);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(224, 23);
            this.saveAndCloseButton.TabIndex = 4;
            this.saveAndCloseButton.Text = "Save and close";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            // 
            // emplListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 407);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.addEmplButton);
            this.Controls.Add(this.modifyEmplButton);
            this.Controls.Add(this.delateEmplButton);
            this.Controls.Add(this.listView1);
            this.Name = "emplListForm";
            this.Text = "emplListForm";
            this.Load += new System.EventHandler(this.emplListForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button delateEmplButton;
        private System.Windows.Forms.Button modifyEmplButton;
        private System.Windows.Forms.Button addEmplButton;
        private System.Windows.Forms.Button saveAndCloseButton;
    }
}