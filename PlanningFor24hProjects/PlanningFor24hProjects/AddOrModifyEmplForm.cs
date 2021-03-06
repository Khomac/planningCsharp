﻿using System;
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
        EmplListForm emplListForm = null;

        public AddOrModifyEmplForm(EmplListForm emplListForm)
        {
            InitializeComponent();
            this.emplListForm = emplListForm;
        }

        private void saveAndExitButton_Click(object sender, EventArgs e) 
        {
            ListViewItem emplListViewItem = new ListViewItem(NameAndSurnameTextBox.Text.ToString()); //dodanie itemow z trescia textu
            //emplListViewItem.SubItems.Add(NameAndSurnameTextBox.Text.ToString()); //do dodawania subitemow
            emplListForm.addItemToEmplListView(emplListViewItem);
            this.Close();
        }
    }
}
