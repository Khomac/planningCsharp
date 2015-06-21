using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace PlanningFor24hProjects
{
    public partial class CalendarForm : Form
    {
        ListViewItem calendarItem = null;
        EmplListForm emplListWindow = null; // zadeklarowanie zmeinnej na przyjecie obiektu emplListWindow
        

        private bool listViewMouseDown = true;
        private int year, month = 0;
        

        public CalendarForm(int year, int month, EmplListForm emplListWindow) //przekazanie przez parametr obiektu emplListWindow (tego naszego pierwotnego)
        {
            this.year = year;
            this.month = month;
            this.emplListWindow = emplListWindow;
            InitializeComponent();
        }

        public void updateTranslations() // zaladowanie stringow z metod klasy Translation do .Text elementow tej formy
        {
            shiftTypeBox.Text = Translation.shiftType();
            nightRadioButton.Text = Translation.nightRadioButton();
            dayRadioButton.Text = Translation.dayRadioButton();
            holidayRadioButton.Text = Translation.holidayRadioButton();
            sicknessRadioButton.Text = Translation.sicknessRadioButton();
            emptyRadioButton.Text = Translation.emptyRadioButton();
            clearAllCalendarButton.Text = Translation.clearAllCalendarButton();
            hoursNumberLabel.Text = Translation.hoursNumberLabel();
            createCalendarButton.Text = Translation.createCalendarButton();
            clearAutomaticCalendarButton.Text = Translation.clearAutomaticCalendarButton();
            this.Text = Translation.calendarWindow();

            calendarListView.Columns[0].Text = Translation.nameAndSurname();
            for (int i = 1; i < calendarListView.Columns.Count; i++)
            {
                int dayOfWeek = (int)(new DateTime(year, month, i).DayOfWeek); //DayOfWeek zwraca enuma, trzeba ręcznie zrzutować na inta
                calendarListView.Columns[i].Text = i.ToString() + "\n" + Translation.dayOfWeek(dayOfWeek);
            }
        }

        private void CalendarWindow_Load(object sender, EventArgs e)
        {
            for (int j = 1; j <= DateTime.DaysInMonth(year, month); j++)
            {
                calendarListView.Columns.Add("");
                calendarListView.Columns[j].Width = 23;
            }

            //for (int i = 0; i < 10;i++ ) //petla na zaludnienie kalendarza - tymczasowo by default, pozniej bedzie wykorzystywac elementy z emplListForm
            foreach (ListViewItem item in emplListWindow.getListView().Items)
            {
                calendarItem = new ListViewItem(item.Text);
                for (int j = 0; j < DateTime.DaysInMonth(year, month); j++)
                {
                    calendarItem.SubItems.Add("");
                }
                calendarListView.Items.Add(calendarItem); //przekazanie stworzonego itemu do listView
            }

            updateTranslations(); //odpalenie zaladowania wlasciwych tekstow na etapie ladowania formy
            this.monthAndYearLabel.Text = BaseForm.chosenDateText; //ustawienie labela formy na wybrana date w MonthChoiceForm
        }

        private void calendarField_DrawSubItem(object sender, DrawListViewSubItemEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                e.Graphics.DrawString(e.SubItem.Text, SystemFonts.DefaultFont, Brushes.Red, new PointF(e.Bounds.Left + 2, e.Bounds.Top + 2));
            }
            else
            {
                if (e.SubItem.Text == "D")
                    e.Graphics.FillRectangle(Brushes.Yellow, e.Bounds);
                if (e.SubItem.Text == "N")
                    e.Graphics.FillRectangle(Brushes.CadetBlue, e.Bounds);
                if (e.SubItem.Text == "U")
                    e.Graphics.FillRectangle(Brushes.Green, e.Bounds);
                if (e.SubItem.Text == "L4")
                    e.Graphics.FillRectangle(Brushes.DarkCyan, e.Bounds);
                if (e.SubItem.Text == "") //malowanie pol odpowiadajacych weekendowi na rozowo, a reszty na bialo
                { 
                    if (new DateTime(year, month, e.ColumnIndex).DayOfWeek == DayOfWeek.Saturday ||
                        new DateTime(year, month, e.ColumnIndex).DayOfWeek == DayOfWeek.Sunday)
                        e.Graphics.FillRectangle(Brushes.Pink, e.Bounds);
                    else
                        e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds);
                }
                //tutaj malujemy pola kolorami - odpowiednio 

                e.Graphics.DrawString(e.SubItem.Text, SystemFonts.DefaultFont, Brushes.Black, new PointF(e.Bounds.Left + 2, e.Bounds.Top + 2));
            }
        }



        private void calendarField_MouseUp(object sender, MouseEventArgs e)
        {
            if (listViewMouseDown)
            {
                var info = calendarListView.HitTest(e.X, e.Y);
                if (info.Item != null)
                {
                    var col = info.Item.SubItems.IndexOf(info.SubItem);
                    if (col > 0)
                    {
                        if (dayRadioButton.Checked)
                            info.Item.SubItems[col].Text = "D";
                        if (nightRadioButton.Checked)
                            info.Item.SubItems[col].Text = "N";
                        if (holidayRadioButton.Checked)
                            info.Item.SubItems[col].Text = "U";
                        if (sicknessRadioButton.Checked)
                            info.Item.SubItems[col].Text = "L4";
                        if (emptyRadioButton.Checked)
                            info.Item.SubItems[col].Text = "";

                    }
                }
            }
            listViewMouseDown = false;
        }

        private void calendarField_MouseDown(object sender, MouseEventArgs e)
        {
            listViewMouseDown = true;
        }

        //tutaj pisanie haederow
        private void CalendarField_DrawColumnHeader(object sender, DrawListViewColumnHeaderEventArgs e)
        {
            if (e.ColumnIndex > 0)
            {
                if (new DateTime(year, month, e.ColumnIndex).DayOfWeek == DayOfWeek.Saturday || 
                    new DateTime(year, month, e.ColumnIndex).DayOfWeek == DayOfWeek.Sunday)
                    e.Graphics.FillRectangle(Brushes.Pink, e.Bounds);
            }
            if (e.ColumnIndex == 0)
                e.Graphics.DrawString(e.Header.Text, SystemFonts.DefaultFont, Brushes.Black, new PointF(e.Bounds.Left + 2, e.Bounds.Top + 2));
            else
                e.Graphics.DrawString(e.Header.Text, new Font(new FontFamily("Calibri"),7,FontStyle.Regular), Brushes.Black, new PointF(e.Bounds.Left + 2, e.Bounds.Top + 2));
            e.Graphics.DrawLine(new Pen(Color.Black,2), e.Bounds.Left, e.Bounds.Bottom, e.Bounds.Right, e.Bounds.Bottom);
        }

        private void clearCalendarButton_Click(object sender, EventArgs e) //czyszczenie zawartosci wszystkich pol kalendarza
        {
            foreach (ListViewItem item in calendarListView.Items)
            {
                for (int i = 1; i < item.SubItems.Count;i++ )
                {

                    item.SubItems[i].Text = "";
                }
            }
        }




    }
}
