using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* set (bit-fields) simulation with FlagsAttribute */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        [Flags]
        enum Day { Sun = 1, Mon = 2, Tue = 4, Wed = 8, Thu = 16, Fri = 32, Sat = 64 };
    

        Day GetDaysLeft()
        {
            Day Result = (Day)0;

            if (chSunL.Checked)
                Result = Result | Day.Sun;
            if (chMonL.Checked)
                Result = Result | Day.Mon;
            if (chTueL.Checked)
                Result = Result | Day.Tue;
            if (chWedL.Checked)
                Result = Result | Day.Wed;
            if (chThuL.Checked)
                Result = Result | Day.Thu;
            if (chFriL.Checked)
                Result = Result | Day.Fri;
            if (chSatL.Checked)
                Result = Result | Day.Sat;   

            return Result;
        }

        Day GetDaysRight()
        {
            Day Result = (Day)0;

            if (chSunR.Checked)
                Result = Result | Day.Sun;
            if (chMonR.Checked)
                Result = Result | Day.Mon;
            if (chTueR.Checked)
                Result = Result | Day.Tue;
            if (chWedR.Checked)
                Result = Result | Day.Wed;
            if (chThuR.Checked)
                Result = Result | Day.Thu;
            if (chFriR.Checked)
                Result = Result | Day.Fri;
            if (chSatR.Checked)
                Result = Result | Day.Sat;

            return Result;
        }


        private void btnUnion_Click(object sender, EventArgs e)
        {
            Day A = GetDaysLeft();
            Day B = GetDaysRight();

            Day C = A | B;

            MessageBox.Show(C.ToString());
        }

        private void btnIntersection_Click(object sender, EventArgs e)
        {
            Day A = GetDaysLeft();
            Day B = GetDaysRight();

            Day C = A & B;

            MessageBox.Show(C.ToString());
        }

        private void btnDifference_Click(object sender, EventArgs e)
        {
            Day A = GetDaysLeft();
            Day B = GetDaysRight();

            Day C = A ^ B;
   

            MessageBox.Show(C.ToString());
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            Day A = GetDaysLeft();
            Day B = GetDaysRight(); 
   
            bool Result = (A & B) == A;   // true if A is a subset of B

            MessageBox.Show(Result.ToString());
        }

        private void btnSubtraction_Click(object sender, EventArgs e)
        {
            Day A = GetDaysLeft();
            Day B = GetDaysRight();

            Day C = A ^ (A & B);

            MessageBox.Show(C.ToString());
        }

 




    }
}
