using System;
using System.Drawing;
using System.Windows.Forms;

namespace PlanningFor24hProjects
{
    public partial class CalendarWindow : Form
    {
        ListViewItem calendarItem = null;
        private bool listViewMouseDown = true;
        public CalendarWindow()
        {
            InitializeComponent();
        }



        private void CalendarWindow_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 10;i++ )
            {
                calendarItem = new ListViewItem("Imie i Nazwisko");
                calendarItem.SubItems.Add("");
                calendarItem.SubItems.Add("U");
                calendarItem.SubItems.Add("D");
                calendarItem.SubItems.Add("g");
                calendarItem.SubItems.Add("");
                calendarField.Items.Add(calendarItem);
            }
            

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
                if (e.SubItem.Text == "")
                    e.Graphics.FillRectangle(Brushes.WhiteSmoke, e.Bounds);
                //tutaj malujemy pola kolorami

                e.Graphics.DrawString(e.SubItem.Text, SystemFonts.DefaultFont, Brushes.Black, new PointF(e.Bounds.Left + 2, e.Bounds.Top + 2));
            }
        }



        private void calendarField_MouseUp(object sender, MouseEventArgs e)
        {
            if (listViewMouseDown)
            {
                var info = calendarField.HitTest(e.X, e.Y);
                if (info.Item != null)
                {
                    var col = info.Item.SubItems.IndexOf(info.SubItem);
                    if (col > 0)
                    {
                        if (radioButton1.Checked)
                            info.Item.SubItems[col].Text = "D";
                        if (radioButton2.Checked)
                            info.Item.SubItems[col].Text = "N";
                        if (radioButton3.Checked)
                            info.Item.SubItems[col].Text = "U";
                        if (radioButton4.Checked)
                            info.Item.SubItems[col].Text = "L4";
                        if (radioButton5.Checked)
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
            e.Graphics.DrawString(e.Header.Text, SystemFonts.DefaultFont, Brushes.Black, new PointF(e.Bounds.Left + 2, e.Bounds.Top + 2));
        }



    }
}
