using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* relational operators - if-else statements */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* < and > */
        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            if (x > y)
            {                                         // block braces are not required if the block is just a single line
                MessageBox.Show("x greater than y");
            }
            else if (x < y)
                MessageBox.Show("x lesser than y");
            else
                MessageBox.Show("x equals y");
        }

        /* == and != */
        private void button2_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);

            if (x != y)
                MessageBox.Show("x not equals y");
            else if (x == y)                           // redundant
                MessageBox.Show("x equals y");
    
        }

        /* nested if */
        private void button3_Click(object sender, EventArgs e)
        {
            int x = int.Parse(txtX.Text);
            int y = int.Parse(txtY.Text);
            int n = 0;
            string S = "";

            if (x > y)
            {
                S = "x greater than y. ";

                n = x - y;

                if (n > 3)   // nested if
                {
                    S = S + Environment.NewLine;
                    S = S + "x is at least 3 greater than y";
                }
                    
            }
            else
            {
                S = "x lesser than y. ";

                n = y - x;

                if (n > 3)  // nested if
                {
                    S = S + Environment.NewLine;
                    S = S + "x is at least 3 lesser than y";
                }
                    
            }

            MessageBox.Show(S);
        }
    }
}
