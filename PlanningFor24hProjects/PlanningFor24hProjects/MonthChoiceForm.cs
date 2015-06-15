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
    public partial class MonthChoiceForm : Form
    {
        public MonthChoiceForm()
        {
            InitializeComponent();
        }

        private void MonthChoiceForm_Load(object sender, EventArgs e)
        {
            updateTranslations();
            this.yearChoiceComboBox.SelectedItem = DateTime.Now.Year.ToString(); 
            //fragment do modyfikacji wyswietlania od razu miesiecy na kalendarzu
            for (int i = -2; i <= 4;i++)
                this.yearChoiceComboBox.Items.Add(DateTime.Now.Year + i);
        }

        public void updateTranslations()
        {
            int i = 12;

            foreach (Button s in this.groupBox1.Controls.OfType<Button>())
            {
                i--;
                s.Text = Translation.monthName(i);

            }
            this.Text = Translation.monthChoiceForm();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 11;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BaseWindow.chosenMonth = 12;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
            BaseWindow.chosenDateText = BaseWindow.chosenMonth.ToString() + "/" + BaseWindow.chosenYear.ToString();
        }

        private void yearChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseWindow.chosenYear = Int32.Parse(this.yearChoiceComboBox.Text);
        }



    }
}
