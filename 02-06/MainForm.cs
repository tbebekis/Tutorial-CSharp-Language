using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* DateTime */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        /* initializing DateTime value using the Now property */
        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;

            MessageBox.Show("DateTime.Kind = " + DT.Kind.ToString());
            MessageBox.Show("Local time: " + DT.ToString());
            MessageBox.Show("UTC time: " + DT.ToUniversalTime().ToString());
        }


        /* initializing DateTime value using the Today property */
        private void button2_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Today;

            MessageBox.Show("DateTime.Kind = " + DT.Kind.ToString());
            MessageBox.Show("Local time: " + DT.ToString());
            MessageBox.Show("UTC time: " + DT.ToUniversalTime().ToString());
        }


        /* initializing DateTime value using parameterized constructor */
        private void button3_Click(object sender, EventArgs e)
        {
            DateTime DT = new DateTime(1999, 12, 31);

            MessageBox.Show("DateTime.Kind = " + DT.Kind.ToString());
            MessageBox.Show("Local time: " + DT.ToString());
            MessageBox.Show("UTC time: " + DT.ToUniversalTime().ToString());
        }


        /* initializing DateTime value using Parse() method */
        private void button4_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Parse("1999-12-31");

            MessageBox.Show("DateTime.Kind = " + DT.Kind.ToString());
            MessageBox.Show("Local time: " + DT.ToString());
            MessageBox.Show("UTC time: " + DT.ToUniversalTime().ToString());
        }

        /* using the AddXXXX() methods */
        private void button5_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            DT = DT.AddDays(-365);
            MessageBox.Show(DT.ToString());

            DT = DT.AddYears(10);
            MessageBox.Show(DT.ToString());
        }


        /* TimeSpan class and the -/+ operators */
        private void button6_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            DateTime DT2 = DT.AddDays(-30);

            TimeSpan TS = DT - DT2;
            MessageBox.Show(TS.ToString());

            //TS = DT + DT2;                    // Error: Operator '+' cannot be applied to operands of type 'System.DateTime' and 'System.DateTime'

            DT = DT2 + TS;
            MessageBox.Show(DT.ToString());

            DT = DT2 - TS;
            MessageBox.Show(DT.ToString());

        }

        /* TimeSpan class, the overloaded Subtract() and the Add() method */
        private void button7_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            DateTime DT2 = DT.AddDays(-30);
            TimeSpan TS = DT.Subtract(DT2);

            MessageBox.Show(TS.ToString());

            DT2 = DT2.Subtract(TS);
            MessageBox.Show(DT2.ToString());

            DT2 = DT2.Add(TS);
            MessageBox.Show(DT2.ToString());
        }

        /* comparing DateTime values by using operators and methods */
        private void button8_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            DateTime DT2 = DT.AddSeconds(0.5);

            bool b = DT == DT2;
            MessageBox.Show(b.ToString());

            b = DT <= DT2;
            MessageBox.Show(b.ToString());

            b = DT.Equals(DT2);
            MessageBox.Show(b.ToString());

            b = DT.CompareTo(DT2) < 0;
            MessageBox.Show(b.ToString());

            b = DateTime.Compare(DT, DT2) == 0;
            MessageBox.Show(b.ToString());
        }

        /* DateTime read only properties and informational methods */
        private void button9_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            DateTime DT2 = DT.Date;

            MessageBox.Show(DT.ToString());
            MessageBox.Show(DT2.ToString());

            int i = DT.Year;
            MessageBox.Show("Year: " + i.ToString());

            i = DT.Month;
            MessageBox.Show("Month: " + i.ToString());

            i = DT.Day;
            MessageBox.Show("Day: " + i.ToString());

            i = DT.DayOfYear;
            MessageBox.Show("DayOfYear: " + i.ToString());

            DayOfWeek DOW = DT.DayOfWeek;
            MessageBox.Show("DayOfWeek: " + DOW.ToString());

            MessageBox.Show("Date: " + DT.Date.ToString());

            TimeSpan TOD = DT.TimeOfDay;
            MessageBox.Show("TimeOfDay: " + TOD.ToString());

            MessageBox.Show("IsDaylightSavingTime: " + DT.IsDaylightSavingTime().ToString());
            MessageBox.Show("IsLeapYear: " + DateTime.IsLeapYear(DT.Year).ToString());

        }

        /* GetDateTimeFormats() method */
        private void button10_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;
            string[] a = DT.GetDateTimeFormats();
            string S = "";

            foreach (string f in a)
                S += f + Environment.NewLine;            

            MessageBox.Show(S);
        }

        /* Long and short date and time strings */
        private void button11_Click(object sender, EventArgs e)
        {
            DateTime DT = DateTime.Now;

            MessageBox.Show(DT.ToLongDateString());
            MessageBox.Show(DT.ToLongTimeString());

            MessageBox.Show(DT.ToShortDateString());
            MessageBox.Show(DT.ToShortTimeString());
        }

        /* using ToString() with format string */
        private void button12_Click(object sender, EventArgs e)
        {

            DateTime DT = DateTime.Now;

            MessageBox.Show("Custom format string: "                    + DT.ToString("yyyy-MM-dd"));
            MessageBox.Show("Custom format string: "                    + DT.ToString("yyyy.MM.dd"));
            MessageBox.Show("Custom format string: "                    + DT.ToString("dd/MM/yyyy"));
            MessageBox.Show("Custom format string: "                    + DT.ToString("MM/dd/yy"));

            MessageBox.Show("Custom format string: "                    + DT.ToString("hh:mm:ss"));


            MessageBox.Show("(D) Long date: "                           + DT.ToString("D"));
            MessageBox.Show("(T) Long time: "                           + DT.ToString("T"));
            MessageBox.Show("(d) Short date: "                          + DT.ToString("d"));
            MessageBox.Show("(t) Short time: "                          + DT.ToString("t"));  

            MessageBox.Show("(F) Full date/long time: "                 + DT.ToString("F"));
            MessageBox.Show("(G) General date/long time (default): "    + DT.ToString("G"));          
            MessageBox.Show("(f) Full date/short time: "                + DT.ToString("f"));            
            MessageBox.Show("(g) General date/short time: "             + DT.ToString("g"));
            
            MessageBox.Show("(M) Month: "                               + DT.ToString("M"));
            MessageBox.Show("(Y) Year: "                                + DT.ToString("Y"));
            
            MessageBox.Show("(U) Universal full date/time: "            + DT.ToString("U"));
            MessageBox.Show("(u) Universal sortable (invariant): "      + DT.ToUniversalTime().ToString("u"));
            MessageBox.Show("(R) RFC1123: "                             + DT.ToUniversalTime().ToString("R"));
            MessageBox.Show("(s) Sortable: "                            + DT.ToString("s"));
            
            MessageBox.Show("(o) Roundtrip (local): "                   + DT.ToString("o"));
 

        }

        /* parsing */
        private void button13_Click(object sender, EventArgs e)
        {
            string S = "2000-12-01 22:01:01";
            DateTime DT = DateTime.Parse(S);

            MessageBox.Show(DT.ToString());
        }


    }
}
