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
    public partial class emplListForm : Form
    {
        public emplListForm()
        {
            InitializeComponent();
        }

        private void emplListForm_Load(object sender, EventArgs e)
        {
            updateTranslations();
        }

        public void updateTranslations()
        {
            saveAndCloseButton.Text = Translation.saveAndCloseButton();
            modifyEmplButton.Text = Translation.modifyEmplButton();
            addEmplButton.Text = Translation.addEmplButton();
            delateEmplButton.Text = Translation.delateEmplButton();
            this.Text = Translation.emplListWindow();
        }
    }
}
