using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* boolean operators */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(checkBox1.Checked.ToString());
        }

        private void btnNot_Click(object sender, EventArgs e)
        {
            checkBox2.Checked = !checkBox2.Checked;     // the ! (not) boolean operator - bool values work as switches
        }

        private void btnAnd_Click(object sender, EventArgs e)
        {
            bool A = checkBox1.Checked;
            bool B = checkBox2.Checked;

            if (A && B)                                 // the && (and) boolean operator
                checkBox3.Checked = true;
            else
                checkBox3.Checked = false;

            // it also could be written as
            //checkBox3.Checked = (A && B);


        }

        private void btnOr_Click(object sender, EventArgs e)
        {
            bool A = checkBox1.Checked;
            bool B = checkBox2.Checked;

            if (A || B)                                 // the || (or) boolean operator
                checkBox3.Checked = true;
            else
                checkBox3.Checked = false;

            // it also could be written as
            //checkBox3.Checked = (A || B);
        }

        private void btnXor_Click(object sender, EventArgs e)
        {
            bool A = checkBox1.Checked;
            bool B = checkBox2.Checked;

            if (A ^ B)                                  // the ^ (xor) boolean operator
                checkBox3.Checked = true;
            else
                checkBox3.Checked = false;

            // it also could be written as
            //checkBox3.Checked = (A ^ B);
        }
    }
}
