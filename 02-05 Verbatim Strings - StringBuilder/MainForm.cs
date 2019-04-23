using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* Copy on write (COW) 
    Escape characters and verbatim (literal) strings
    StringBuilder class*/
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* Copy on write (COW) */
        private void button1_Click(object sender, EventArgs e)
        {
            string A = "C sharp";
            string B = A;

            B += " language";       // copy-on-write here

            MessageBox.Show(A);     // displays "C sharp"    
        }

        /*  Escape characters and verbatim (literal) strings */
        private void button2_Click(object sender, EventArgs e)
        {
            string A = "C:\\My Projects\\SomeProject";
            string B = @"C:\My Projects\SomeProject";   // identical to the above
            string C = A + "\n" + B;

            MessageBox.Show(C);
        }

        /* StringBuilder */
        private void button3_Click(object sender, EventArgs e)
        {
            StringBuilder SB = new StringBuilder();

            SB.Append("ABCDEFGHIJKLMNOPQRSTUVWXYZ");

            for (int i = 0; i < SB.Length; i++)  
                SB[i] = char.ToLower(SB[i]);

            MessageBox.Show(SB.ToString());

            SB.Insert(13, "\n");

            MessageBox.Show(SB.ToString());            
        }

        /* string.Format() */
        private void button4_Click(object sender, EventArgs e)
        {
            int i = 123;
            double d = 4.56;
            bool b = true;
            DateTime dt = DateTime.Today;

            string S = string.Format("int = {0}, double = {1}, bool = {2}, DateTime = {3} ", i, d, b, dt);
            MessageBox.Show(S);
        }
    }
}
