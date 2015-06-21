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
    public partial class BaseForm : Form
    {
        public CalendarForm calendarWindow = null;
        public MonthChoiceForm monthChoiceWindow = null;
        public EmplListForm emplListWindow = null;

        public static int chosenMonth = DateTime.Now.Month;
        public static int chosenYear = DateTime.Now.Year;
        public static string chosenDateText = chosenMonth.ToString() + "/" + chosenYear.ToString();


        public BaseForm()
        {
            InitializeComponent();
        }

        public void updateTranslations()// zaladowanie stringow z metod klasy Translation do .Text elementow tej formy
        {
            openCalendarButton.Text = Translation.openCalendarButton();
            languageLabel.Text = Translation.languageLabel();
            calendarModeLabel.Text = Translation.calendarModeLabel();
            workModeLabel.Text = Translation.workModeLabel();
            modifyEmplListButton.Text = Translation.modifyEmplListButton();
            chosenDateLabel.Text = Translation.chosenDateLabel();
            dateChoiceButton.Text = Translation.dateChoiceButton();
            this.Text = Translation.baseWindow();
        }

        private void openCalendarButton_Click(object sender, EventArgs e)
        {
            calendarWindow = new CalendarForm(chosenYear, chosenMonth); // wartosci wybrane wczesniej z kalendarza albo domyslne
            calendarWindow.Visible = true;
        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {
            updateTranslations(); //odpalenie zaladowania wlasciwych tekstow na etapie ladowania formy
        }


        //ladowanie zmeinnej globalnej chosenLanguage wlasciwymi etykietami po wyborze z comboboxa
        private void languageChoiceCombobox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = languageChoiceComboBox.Text.ToString();
            if (selectedItem == "Polski")
                Translation.chosenLanguage = "PL";
            if (selectedItem == "Francais")
                Translation.chosenLanguage = "FR";
            if (selectedItem == "English")
                Translation.chosenLanguage = "EN";

            this.updateTranslations();
            if (calendarWindow != null)
                calendarWindow.updateTranslations();
            if (monthChoiceWindow != null)
                monthChoiceWindow.updateTranslations();
            if (emplListWindow != null)
                emplListWindow.updateTranslations();

        }

        private void dateChoiceButton_Click(object sender, EventArgs e) //otwarcie okna wyboru miesiaca
        {
            //if (monthChoiceWindow==null) //opracowac lepszy sprawdzacz czy otwarta jest tylko jedna forma naraz
            {
                monthChoiceWindow = new MonthChoiceForm();
                monthChoiceWindow.Visible = true;
            }
        }

        private void modifyEmplListButton_Click(object sender, EventArgs e) //otwarcie okna wyboru pracownikow (opracowac metode na tylko jedno okienko otwarte naraz)
        {
            if(emplListWindow == null)
                emplListWindow = new EmplListForm();
            emplListWindow.Visible = true;
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            updateTranslations();
        }



    }
}

