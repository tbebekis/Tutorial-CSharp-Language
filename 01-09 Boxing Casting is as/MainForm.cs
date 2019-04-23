using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* boxing-casting-convertions-is-as etc. */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        /* implicit/explicit convertions */
        private void button1_Click(object sender, EventArgs e)
        {
            int i = 0;
            long n = i;             // implicit convertion, int to long

            n = long.MaxValue;
            i = (int)n;             // long.MaxValue is a really big value for int, so we have loss of information here

            MessageBox.Show(n.ToString());
            MessageBox.Show(i.ToString());

            //bool b = (bool)i;     // Error: Cannot convert type 'int' to 'bool'	       
        }

        /* checked */
        private void button2_Click(object sender, EventArgs e)
        {
            checked
            {
                long n = long.MaxValue;
                int i = (int)n;                 // OverflowException here

                MessageBox.Show(n.ToString());
                MessageBox.Show(i.ToString());

            }
        }

        /* unchecked */
        private void button3_Click(object sender, EventArgs e)
        {
            unchecked
            {
                long n = long.MaxValue;
                int i = (int)n;                 // NO OverflowException here

                MessageBox.Show(n.ToString());
                MessageBox.Show(i.ToString());

            }
        }

        /* is and as operators */
        private void CommonClickHandler(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                string S = (sender as Button).Text;
                MessageBox.Show(S);
            }
            else if (sender is TextBox)
            {
                string S = (sender as TextBox).Text;
                MessageBox.Show(S);
            }
        }

        /* the as operator returns null on failure, not exception */
        private void button5_Click(object sender, EventArgs e)
        {
            TextBox Box = sender as TextBox;
            if (Box != null)
            {
            }
            else
                MessageBox.Show("sender is not a TextBox");
        }

        /* typeof and GetType() */
        private void button6_Click(object sender, EventArgs e)
        {
            Type T = typeof(string);
            MessageBox.Show(T.FullName);

            MessageBox.Show(typeof(MainForm).FullName);

            T = this.GetType();
            MessageBox.Show(T.FullName);
        }

        /* the ?: conditional operator */
        private void CommonClickHandler2(object sender, EventArgs e)
        {
            object V = (sender is TextBox) ? sender : this;
            MessageBox.Show(V.ToString());
        }

        /* operator precedence */
        private void button8_Click(object sender, EventArgs e)
        {
            double V = 4 + 4 / 2;
            MessageBox.Show(V.ToString());

            V = (4 + 4) / 2;
            MessageBox.Show(V.ToString());
        }


        /* boxing and unboxing */
        private void button9_Click(object sender, EventArgs e)
        {
            int i = 100;        // a value type
            
            object Obj = i;     // boxing
            MessageBox.Show(Obj.ToString());

            int x = (int)Obj;   // unboxing
            MessageBox.Show(x.ToString());
        }


    }
}
