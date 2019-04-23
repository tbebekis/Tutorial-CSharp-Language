using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* Lambda Expressions */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public delegate void StringDelegate(string Text);

        public void Display(string S)
        {
            MessageBox.Show("Named method: " + S);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // a named method
            StringDelegate d = Display;


            // an anonymous method
            d += delegate(string S)
            {
                MessageBox.Show("Anonymous method: " + S);
            };

 
            // a lambda expression
            d += (S) =>
            {
                MessageBox.Show("Lambda expression: " + S);
            };

            d("Hi there!");
        }





        public delegate int MathDelegate(int a, int b, int c);

        private void button2_Click(object sender, EventArgs e)
        {
            // multiple parameters
            MathDelegate d = (x, y, z) => { return x + y + z; };

            string S = d(1, 2, 3).ToString();

            MessageBox.Show(S);
        }



        /* a lambda expression defined outside of any method, it is actually a field
           such a lambda expression can use only static fields */
        int a = 1;
        static int b = 2;
        MathDelegate d = (x, y, z) => { return x + y + z + b; };

        private void button3_Click(object sender, EventArgs e)
        {
            int c = 3;

            string S = d(a, b, c).ToString();
            MessageBox.Show(S);

            MathDelegate d2 = (x, y, z) => { return x + y + z + a + b + c; };

            S = d2(a, b, c).ToString();
            MessageBox.Show(S);
        }

    }
}
