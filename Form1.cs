using System;
using System.Windows.Forms;

namespace Month_Calender_Control_OnTextbox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            // When the date changes in the MonthCalendar control, this event is triggered.
           
            DateTime selectedDate = monthCalendar1.SelectionRange.Start;
          //  txtDay.Text = selectedDate.Day.ToString();
            txtYear.Text = selectedDate.Year.ToString();
            txtDay.Text = selectedDate.ToString("dddd"); 
            txtMonth.Text = selectedDate.ToString("MMMM");
            txtDT.Text = $"{selectedDate.Day}/{selectedDate.Month}/{selectedDate.Year}";
        }
    } 
}
