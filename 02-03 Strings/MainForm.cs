using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* string operators
   strings are arrays of unicode characters
   empty strings 
   null strings*/
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }



        /* concatenation and equality operators */
        private void button1_Click(object sender, EventArgs e)
        {
            string S = "Hi" + " there";
            string S2 = "Hi there";

            if (S == S2)
                MessageBox.Show(S + " == " + S2);

            if (S != "Hi there")
                MessageBox.Show("not equal strings");

        }

        /* strings are read only arrays of unicode characters */
        private void button2_Click(object sender, EventArgs e)
        {
            string S = "Csharp";
            string S2 = "";

            // Length is a property of the class string
            for (int i = 0; i < S.Length; i++)
                S2 += S[i].ToString() + Environment.NewLine;

            MessageBox.Show(S2);

        }


        /* empty strings
           An empty string represents a blank text field. 
           It is valid to call methods on empty strings because they are valid System.String objects
         */
        private void button3_Click(object sender, EventArgs e)
        {
            string S = "";
            string S2 = string.Empty;

            if ((S == string.Empty) && (S2 == string.Empty))
                MessageBox.Show("both strings are empty");
        }


        /* null strings
           A null string does not refer to an instance of System.String class.
           Any attempt to call a method on a null string causes a NullReferenceException.
           Besides that it is valid to use null strings in concatenation and comparison operations with other strings.
         */
        private void button4_Click(object sender, EventArgs e)
        {
            string S = "Hi there";
            string S2 = null;
            string S3 = "";

            // concatenating a string and a null string
            S = S + S2;
            MessageBox.Show(S);
            
            
            // calling a method on a null string
            try
            {
                int i = S2.Length;
                MessageBox.Show(i.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }


            // comparing an empty string to a null string returns false
            bool b = S2 == S3;
            MessageBox.Show(b.ToString());


            // The IsNullOrEmpty() static method returns true if a string is null or empty
            if (string.IsNullOrEmpty(S3))
                MessageBox.Show("IsNullOrEmpty");
        }



    }
}
