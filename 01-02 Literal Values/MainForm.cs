using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* literal values */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* reference type literals */
        private void button1_Click(object sender, EventArgs e)
        {
            object V = null;
            V = new Button();

            MessageBox.Show(V.ToString());
        }

        /* boolean type literals */
        private void button2_Click(object sender, EventArgs e)
        {
            bool V = true;
            MessageBox.Show(V.ToString());
        }

        /* integer type literals */
        private void button3_Click(object sender, EventArgs e)
        {
            ulong x = 234UL;

            x = x - 123ul;

            MessageBox.Show(x.ToString());

            x = 0xAB;                           // hexadecimal notation
            MessageBox.Show(x.ToString());
        }

        /* float type literals */
        private void button4_Click(object sender, EventArgs e)
        {
            double V = 1.2d;
            MessageBox.Show(V.ToString());

            decimal V2 = 123.456m;
            //V2 = V + V2;                    // compile-time error: Operator '+' cannot be applied to operands of type 'double' and 'decimal'	 

            MessageBox.Show(V2.ToString());
        }


        /* string and char type literals */
        private void button5_Click(object sender, EventArgs e)
        {
            char NewLine = '\n';
            string S = "Hi " + NewLine + "there";
            MessageBox.Show(S);

            // more safe to get the new line character sequence from the Environment class
            S = "Hi " + Environment.NewLine + "there";
            MessageBox.Show(S);

            char Space = '\u0020';                      // unicode character notation                        
            S = "Hi" + Space + "there";
            MessageBox.Show(S);
        }

        /* verbatim strings and escaping characters in a string */
        private void button6_Click(object sender, EventArgs e)
        {

            string S = @"Hi there";
            MessageBox.Show(S);

            S = "Hi \n there";
            MessageBox.Show(S);

            S = @"Hi \n there";
            MessageBox.Show(S);

            S = "I'm saying \"Hello\" to you";
            MessageBox.Show(S);

            S = @"I'm saying ""Hello"" to you";
            MessageBox.Show(S);

            S = "C:\\Temp\\data.txt";
            MessageBox.Show(S);

            S = @"C:\Temp\data.txt";
            MessageBox.Show(S);

            S = @"one
                  two
                  three";
            MessageBox.Show(S);
  

        }
    }
}
