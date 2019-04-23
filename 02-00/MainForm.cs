using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* enum types */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            cboDay.SelectedIndex = 0;
        }
         
        enum Day { Sun = 1, Mon = 2, Tue = 3, Wed = 3, Thu, Fri, Sat };

        /* enums are actually integer values */
        private void button1_Click(object sender, EventArgs e)
        {
            Day D = Day.Fri;   
            int i = (int)D;                            // the integer value of Day.Fri depends on the ordinality of the constant

            MessageBox.Show(i.ToString());
        }


        /* converting enums to strings */
        private void button2_Click(object sender, EventArgs e)
        {
            Day D = Day.Wed;
            MessageBox.Show(D.ToString());

            string[] Names = Enum.GetNames(typeof(Day));    // get the names of the enum constants as an array
            string S = "";

            for (int i = 0; i < Names.Length; i++)
                S = S + Names[i] + Environment.NewLine;

            MessageBox.Show(S);       
        }

        /* converting a string to an enum value */
        private void button3_Click(object sender, EventArgs e)
        {
            Day D = (Day)Enum.Parse(typeof(Day), cboDay.Text, true);  // convert a string to an enum value

            if ((D >= Day.Mon) && (D <= Day.Fri))
                MessageBox.Show("it's a working day");
            else
                MessageBox.Show("weekend day");
        }
    }
}
