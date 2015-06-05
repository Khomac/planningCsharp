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

        private void openCalendarButton_Click(object sender, EventArgs e)
        {
            calendarWindow = new CalendarWindow();
            calendarWindow.Visible = true;
        }

        private void BaseWindow_Load(object sender, EventArgs e)
        {
            //openCalendarButton.Text = openCalendarButtonText[chosenLanguage];
            //nastepnie wstawie loadery dla pozostalych przyciskow/pol/labeli/nazwy/etc
        }

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

    }
}

