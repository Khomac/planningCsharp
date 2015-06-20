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
    public partial class AddNewProjectForm : Form
    {
        public AddNewProjectForm()
        {
            InitializeComponent();
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
