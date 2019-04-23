using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* string methods */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* Insert(), Replace(), IndexOf() and  Remove() string instance methods */
        private void button1_Click(object sender, EventArgs e)
        {
            string S = "C sharp is a programming language";

            S = S.Insert(12, " new");
            MessageBox.Show(S);

            S = S.Replace("new", "great");
            MessageBox.Show(S);

            int i = S.IndexOf("programming ");
            S = S.Remove(i, "programming ".Length);
            MessageBox.Show(S);

            bool b = S.Contains("great");
            MessageBox.Show(b.ToString());
        }

        /* the remarkable Concat() and Join() string static methods */
        private void button2_Click(object sender, EventArgs e)
        {
            object[] a = new object[] {123, 345.6, false, this.Bounds, "string", (sender as Button).TextAlign };
            string S = string.Concat(a);
            MessageBox.Show(S);

            S = string.Join(" ", new string[] {"C", "sharp", "is", "a", "great", "language" });
            MessageBox.Show(S);
 
        }

        /* StartsWith(), EndsWith(), Contains() */
        private void button3_Click(object sender, EventArgs e)
        {
            string S = "C sharp is a great programming language";

            if (S.StartsWith("C sharp"))
                MessageBox.Show("S starts whith C sharp");

            if (S.EndsWith("language"))
                MessageBox.Show("S ends with language");

            if (S.Contains("great"))
                MessageBox.Show("S contains great");
        }

        /* PadLeft(), PadRight() */
        private void button4_Click(object sender, EventArgs e)
        {
            string S = 1234.ToString();

            S = S.PadLeft(8, '0');
            MessageBox.Show(S);

            S = "Value";
            S = S.PadRight(30) + ": " + 1234.ToString();
            MessageBox.Show(S);

        }

        /* ToUpper(), ToLower() */
        private void button5_Click(object sender, EventArgs e)
        {
            string S = "C sharp is a great programming language";
            S = S.ToUpper();

            MessageBox.Show(S);

            S = S.ToLower();
            MessageBox.Show(S);

        }

        /* Trim(), TrimEnd(), TrimStart() */
        private void button6_Click(object sender, EventArgs e)
        {
            string S = "    C sharp is a great programming language    ";
            S = S.Trim();
            MessageBox.Show(S);
        }


        /* Substring(), Split() */
        private void button7_Click(object sender, EventArgs e)
        {
            string S = "C sharp is a great programming language";
            S = S.Substring(8);
            MessageBox.Show(S);

            string[] a = S.Split(' ');
            S = "";

            foreach (string s2 in a)
                S += s2 + Environment.NewLine;

            MessageBox.Show(S);

       
        }

        /* Equals(), CompareTo(), Compare() */
        private void button8_Click(object sender, EventArgs e)
        {
            string S = "123";            

            bool b = S.Equals("123");
            MessageBox.Show(b.ToString());

            int i = 123;
            b = S.CompareTo(i.ToString()) == 0;
            MessageBox.Show(b.ToString());        

            b = string.Compare("C SHARP", "c sharp", true) == 0;
            MessageBox.Show(b.ToString());     
        }
    }
}
