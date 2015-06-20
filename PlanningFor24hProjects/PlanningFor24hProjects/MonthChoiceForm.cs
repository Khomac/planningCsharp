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
        public CalendarForm calendarWindow = null;

        
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
                this.yearChoiceComboBox.Items.Add(DateTime.Now.Year + i); //dodanie lat od teraz -2 do +4
        }

        public void updateTranslations() // zaladowanie stringow z metod klasy Translation do .Text elementow tej formy
        {
            int i = 12;

            foreach (Button s in this.monthChoiceGroupBox.Controls.OfType<Button>())
            {
                i--;
                s.Text = Translation.monthName(i);

            }
            this.Text = Translation.monthChoiceForm();
            openCalendarButton.Text = Translation.openCalendarButton();
            saveAndCloseButton.Text = Translation.saveAndCloseButton();

        }

//ustawienie miesiaca wynikajace z klikniecia w odpowiedni przycisk
        private void button1_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 10;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 11;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            BaseForm.chosenMonth = 12;
        }

        private void saveAndCloseButton_Click(object sender, EventArgs e)
        {
            BaseForm.chosenDateText = BaseForm.chosenMonth.ToString() + "/" + BaseForm.chosenYear.ToString();
            this.Close();
            //this.Dispose(); //mialo sluzyc wyzerowaniu obiektu, zeby dalo sie sprawdzic czy jest null zeby nie bylo dwoch otwartych okien naraz
        }

//wybranie roku wynikajace z wybrania odpowiedniego roku z comboboxa
        private void yearChoiceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            BaseForm.chosenYear = Int32.Parse(this.yearChoiceComboBox.Text);
        }

        private void openCalendarButton_Click(object sender, EventArgs e)
        {
            calendarWindow = new CalendarForm(BaseForm.chosenYear, BaseForm.chosenMonth); // wartosci wybrane z kalendarza
            calendarWindow.Visible = true;
            this.Close();
            //this.Dispose(); //mialo sluzyc wyzerowaniu obiektu, zeby dalo sie sprawdzic czy jest null zeby nie bylo dwoch otwartych okien naraz
        }



    }
}
