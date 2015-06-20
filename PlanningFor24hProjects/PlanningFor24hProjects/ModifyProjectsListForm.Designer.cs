namespace PlanningFor24hProjects
{
    partial class ModifyProjectsListForm
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
            this.addNewProjectButton = new System.Windows.Forms.Button();
            this.delateSelectedButton = new System.Windows.Forms.Button();
            this.saveAndCloseButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(507, 214);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addNewProjectButton
            // 
            this.addNewProjectButton.Location = new System.Drawing.Point(13, 233);
            this.addNewProjectButton.Name = "addNewProjectButton";
            this.addNewProjectButton.Size = new System.Drawing.Size(250, 29);
            this.addNewProjectButton.TabIndex = 1;
            this.addNewProjectButton.Text = "addNewProjectButton";
            this.addNewProjectButton.UseVisualStyleBackColor = true;
            this.addNewProjectButton.Click += new System.EventHandler(this.addNewProjectButton_Click);
            // 
            // delateSelectedButton
            // 
            this.delateSelectedButton.Location = new System.Drawing.Point(12, 268);
            this.delateSelectedButton.Name = "delateSelectedButton";
            this.delateSelectedButton.Size = new System.Drawing.Size(250, 29);
            this.delateSelectedButton.TabIndex = 2;
            this.delateSelectedButton.Text = "delateSelectedButton";
            this.delateSelectedButton.UseVisualStyleBackColor = true;
            // 
            // saveAndCloseButton
            // 
            this.saveAndCloseButton.Location = new System.Drawing.Point(269, 232);
            this.saveAndCloseButton.Name = "saveAndCloseButton";
            this.saveAndCloseButton.Size = new System.Drawing.Size(250, 65);
            this.saveAndCloseButton.TabIndex = 3;
            this.saveAndCloseButton.Text = "saveAndCloseButton";
            this.saveAndCloseButton.UseVisualStyleBackColor = true;
            this.saveAndCloseButton.Click += new System.EventHandler(this.saveAndCloseButton_Click);
            // 
            // ModifyProjectsListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(530, 311);
            this.Controls.Add(this.saveAndCloseButton);
            this.Controls.Add(this.delateSelectedButton);
            this.Controls.Add(this.addNewProjectButton);
            this.Controls.Add(this.listView1);
            this.Name = "ModifyProjectsListForm";
            this.Text = "ModifyProjectsListForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addNewProjectButton;
        private System.Windows.Forms.Button delateSelectedButton;
        private System.Windows.Forms.Button saveAndCloseButton;
    }
}