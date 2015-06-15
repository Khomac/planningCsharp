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
    public partial class BaseWindow : Form
    {
        public CalendarWindow calendarWindow = null;


        public BaseWindow()
        {
            InitializeComponent();
        }

        public void updateTranslations()
        {
            openCalendarButton.Text = Translation.openCalendarButton();
            languageLabel.Text = Translation.languageLabel();
            calendarModeLabel.Text = Translation.calendarModeLabel();
            workModeLabel.Text = Translation.workModeLabel();
            datePickerLabel.Text = Translation.datePickerLabel();
            modifyEmplListButton.Text = Translation.modifyEmplListButton();
            this.Text = Translation.baseWindow();
        }

        private void openCalendarButton_Click(object sender, EventArgs e)
        {
            calendarWindow = new CalendarWindow(2015, 7); //zmodyfikowac na wartosci wybrane z kalendarza
            calendarWindow.Visible = true;
        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {
            updateTranslations();

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
        }

    }
}

