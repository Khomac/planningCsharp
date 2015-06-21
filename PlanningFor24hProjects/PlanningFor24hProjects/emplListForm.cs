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
    public partial class EmplListForm : Form
    {
        public ModifyProjectsListForm modifyProjectsListWindow;
        public AddOrModifyEmplForm addOrModifyEmplWindow;
        public static ListViewItem emplListViewItem;

        public EmplListForm()
        {
            InitializeComponent();
        }

        private void emplListForm_Load(object sender, EventArgs e)
        {
            updateTranslations();
            
        }

        public void updateTranslations() // zaladowanie stringow z metod klasy Translation do .Text elementow tej formy
        {
            saveAndCloseButton.Text = Translation.saveAndCloseButton();
            modifyEmplButton.Text = Translation.modifyEmplButton();
            addEmplButton.Text = Translation.addEmplButton();
            delateEmplButton.Text = Translation.delateEmplButton();
            this.Text = Translation.emplListWindow();
        }

        private void modifyProjectsListButton_Click(object sender, EventArgs e)
        {
            modifyProjectsListWindow = new ModifyProjectsListForm();
            modifyProjectsListWindow.Visible = true;
        }

        private void addEmplButton_Click(object sender, EventArgs e)
        {
            addOrModifyEmplWindow = new AddOrModifyEmplForm(this); //zaznaczenie ze argumenty maja byc przekazywane do tej metody z addOrModifyEmplWindow
            addOrModifyEmplWindow.Visible = true;
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        public void addItemToEmplListView(ListViewItem itemToAdd)
        {
            emplListView.Items.Add(itemToAdd);
            
        }

    }
}
