using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlanningFor24hProjects
{
    public partial class ModifyProjectsListForm : Form
    {
        public AddNewProjectForm addNewProjectWindow;

        public ModifyProjectsListForm()
        {
            InitializeComponent();
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addNewProjectButton_Click(object sender, EventArgs e)
        {
            addNewProjectWindow = new AddNewProjectForm();
            addNewProjectWindow.Visible = true;
        }
    }
}
