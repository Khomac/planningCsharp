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

        Dictionary<string, string> openCalendarButtonText = null;
        Dictionary<string, string> languageLabelText = null;
        Dictionary<string, string> calendarModeLabelText = null;
        Dictionary<string, string> workModeLabelText = null;
        Dictionary<string, string> datePickerLabelText = null;
        Dictionary<string, string> modifyEmplListButtonText = null;
        Dictionary<string, string> baseWindowText = null;


        public BaseWindow()
        {
            InitializeComponent();
        }

        private void openCalendarButton_Click(object sender, EventArgs e)
        {
            calendarWindow = new CalendarWindow();
            calendarWindow.Visible = true;
        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {

            
            openCalendarButtonText = new Dictionary<string, string>();

            openCalendarButtonText.Add("PL", "Wczytaj kalendarz");
            openCalendarButtonText.Add("EN", "Load calendar");
            openCalendarButtonText.Add("FR", "Ouvrir le calendrier");

            openCalendarButton.Text = openCalendarButtonText[Var.chosenLanguage];

            languageLabelText = new Dictionary<string, string>();

            languageLabelText.Add("PL", "Język");
            languageLabelText.Add("EN", "Language");
            languageLabelText.Add("FR", "Longue");

            languageLabel.Text = languageLabelText[Var.chosenLanguage];

            calendarModeLabelText = new Dictionary<string, string>();

            calendarModeLabelText.Add("PL", "Rodzaj kalendarza");
            calendarModeLabelText.Add("EN", "Calendar mode");
            calendarModeLabelText.Add("FR", "Mode du calendrier");

            calendarModeLabel.Text = calendarModeLabelText[Var.chosenLanguage];

            workModeLabelText = new Dictionary<string, string>();

            workModeLabelText.Add("PL", "Tryb pracy");
            workModeLabelText.Add("EN", "Work mode");
            workModeLabelText.Add("FR", "Mode du travail");

            workModeLabel.Text = workModeLabelText[Var.chosenLanguage];

            datePickerLabelText = new Dictionary<string, string>();

            datePickerLabelText.Add("PL", "Pierwszy miesiąc");
            datePickerLabelText.Add("EN", "First month");
            datePickerLabelText.Add("FR", "Premier mois"); //tutaj zrobic drugi dictionary jako alternatywny wybor zaleznie od zawartosci pola wyboru calendar mode

            datePickerLabel.Text = datePickerLabelText[Var.chosenLanguage];

            modifyEmplListButtonText = new Dictionary<string, string>();

            modifyEmplListButtonText.Add("PL", "Zmodyfikuj listę pracowników");
            modifyEmplListButtonText.Add("EN", "Modify employee list");
            modifyEmplListButtonText.Add("FR", "Modifie la liste des employees");

            modifyEmplListButton.Text = modifyEmplListButtonText[Var.chosenLanguage];

            baseWindowText = new Dictionary<string, string>();

            baseWindowText.Add("PL", "Ustawienia");
            baseWindowText.Add("EN", "Settings");
            baseWindowText.Add("FR", "Parametres");

            this.Text = baseWindowText[Var.chosenLanguage];
        }

        //fragment do modyfikacji 
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
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = languageChoiceComboBox.Text.ToString();
            if (selectedItem == "Polski")
                Var.chosenLanguage = "PL";
            if (selectedItem == "Francais")
                Var.chosenLanguage = "FR";
            if (selectedItem == "English")
                Var.chosenLanguage = "EN";

            openCalendarButton.Text = openCalendarButtonText[Var.chosenLanguage];
            languageLabel.Text = languageLabelText[Var.chosenLanguage];
            calendarModeLabel.Text = calendarModeLabelText[Var.chosenLanguage];
            workModeLabel.Text = workModeLabelText[Var.chosenLanguage];
            datePickerLabel.Text = datePickerLabelText[Var.chosenLanguage];
            modifyEmplListButton.Text = modifyEmplListButtonText[Var.chosenLanguage];
            this.Text = baseWindowText[Var.chosenLanguage];
        }

    }
}

