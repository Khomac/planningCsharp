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

        public Dictionary<string, string> openCalendarButtonText = null;
        public Dictionary<string, string> languageLabelText = null;
        public Dictionary<string, string> calendarModeLabelText = null;
        public Dictionary<string, string> workModeLabelText = null;
        public Dictionary<string, string> datePickerLabelText = null;
        public Dictionary<string, string> modifyEmplListButtonText = null;
        public Dictionary<string, string> baseWindowText = null;


        public BaseWindow()
        {
            InitializeComponent();
        }

        private void openCalendarButton_Click(object sender, EventArgs e)
        {
            calendarWindow = new CalendarWindow(2015, 7);
            calendarWindow.Visible = true;
        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {
            //languageChoiceComboBox.SelectedIndex = 2; //i to nie dziala, kiedy sie ustawi - nie wiedziec czemu
            
            openCalendarButtonText = new Dictionary<string, string>();

            openCalendarButtonText.Add("PL", "Wczytaj kalendarz");
            openCalendarButtonText.Add("EN", "Load calendar");
            openCalendarButtonText.Add("FR", "Ouvrir le calendrier");

            openCalendarButton.Text = openCalendarButtonText[Translation.chosenLanguage];

            languageLabelText = new Dictionary<string, string>();

            languageLabelText.Add("PL", "Język");
            languageLabelText.Add("EN", "Language");
            languageLabelText.Add("FR", "Longue");

            languageLabel.Text = languageLabelText[Translation.chosenLanguage];

            calendarModeLabelText = new Dictionary<string, string>();

            calendarModeLabelText.Add("PL", "Rodzaj kalendarza");
            calendarModeLabelText.Add("EN", "Calendar mode");
            calendarModeLabelText.Add("FR", "Mode du calendrier");

            calendarModeLabel.Text = calendarModeLabelText[Translation.chosenLanguage];

            workModeLabelText = new Dictionary<string, string>();

            workModeLabelText.Add("PL", "Tryb pracy");
            workModeLabelText.Add("EN", "Work mode");
            workModeLabelText.Add("FR", "Mode du travail");

            workModeLabel.Text = workModeLabelText[Translation.chosenLanguage];

            datePickerLabelText = new Dictionary<string, string>();

            datePickerLabelText.Add("PL", "Pierwszy miesiąc");
            datePickerLabelText.Add("EN", "First month");
            datePickerLabelText.Add("FR", "Premier mois"); //tutaj zrobic drugi dictionary jako alternatywny wybor zaleznie od zawartosci pola wyboru calendar mode

            datePickerLabel.Text = datePickerLabelText[Translation.chosenLanguage];

            modifyEmplListButtonText = new Dictionary<string, string>();

            modifyEmplListButtonText.Add("PL", "Zmodyfikuj listę pracowników");
            modifyEmplListButtonText.Add("EN", "Modify employee list");
            modifyEmplListButtonText.Add("FR", "Modifie la liste des employees");

            modifyEmplListButton.Text = modifyEmplListButtonText[Translation.chosenLanguage];

            baseWindowText = new Dictionary<string, string>();

            baseWindowText.Add("PL", "Ustawienia");
            baseWindowText.Add("EN", "Settings");
            baseWindowText.Add("FR", "Parametres");

            this.Text = baseWindowText[Translation.chosenLanguage];
        }

        //fragment do modyfikacji wyswietlania od razu miesiecy na kalendarzu
        private void dateTimePicker1_DropDown(object sender, EventArgs e)
        {

            IntPtr cal = SendMessage(dateTimePicker1.Handle, DTM_GETMONTHCAL, IntPtr.Zero, IntPtr.Zero);
            SendMessage(cal, MCM_SETCURRENTVIEW, IntPtr.Zero, (IntPtr)1);
        }
        // pinvoke:
        private const int DTM_GETMONTHCAL = 0x1000 + 8;
        private const int MCM_SETCURRENTVIEW = 0x1000 + 32;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int msg, IntPtr wp, IntPtr lp);


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

            openCalendarButton.Text = openCalendarButtonText[Translation.chosenLanguage];
            languageLabel.Text = languageLabelText[Translation.chosenLanguage];
            calendarModeLabel.Text = calendarModeLabelText[Translation.chosenLanguage];
            workModeLabel.Text = workModeLabelText[Translation.chosenLanguage];
            datePickerLabel.Text = datePickerLabelText[Translation.chosenLanguage];
            modifyEmplListButton.Text = modifyEmplListButtonText[Translation.chosenLanguage];
            this.Text = baseWindowText[Translation.chosenLanguage];

            if (calendarWindow != null)
            {
                calendarWindow.updateTranslations();
            }
        }

    }
}

