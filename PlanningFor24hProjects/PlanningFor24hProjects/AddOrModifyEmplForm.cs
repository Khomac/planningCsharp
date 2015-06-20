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
    public partial class AddOrModifyEmplForm : Form
    {
        public AddOrModifyEmplForm()
        {
            InitializeComponent();
        }

        private void saveAndExitButton_Click(object sender, EventArgs e) 
        {
            EmplListForm.emplListViewItem = new ListViewItem();
            EmplListForm.emplListViewItem.SubItems.Add("pierwszeimie"/*surnameTextBox.Text.ToString()*/);
            //EmplListForm.emplListView.Items.Add(emplListViewItem); //a to nie dziala
            this.Close();
        }
    }
}
