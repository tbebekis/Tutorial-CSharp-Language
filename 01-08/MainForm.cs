using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* nullable types */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* declaring a nullable type variable */
        private void button1_Click(object sender, EventArgs e)
        {
            int? i = null;
            i = 123;

            MessageBox.Show(i.GetType().FullName);
            MessageBox.Show(i.ToString());
        }


        /* mixing nullable and non-nullable types and convertions */
        private void button2_Click(object sender, EventArgs e)
        {
            int? i = 123;
            //int x = i;       // Error : Cannot implicitly convert type 'int?' to 'int'. An explicit conversion exists (are you missing a cast?)
            int x = (int)i;    // explicit convertion, will throw an exception if the nullable type is null

            MessageBox.Show(x.ToString());

            x = 345;
            i = x;             // implicit convertion, a non-nullable is converted to a nullable type, it always succeds 

            MessageBox.Show(i.ToString());

        }

        /* HasValue and Value properties of a nullable type */
        private void button3_Click(object sender, EventArgs e)
        {
            bool? a = null;
            bool b;

            if (a.HasValue)
                b = a.Value;
            else
                b = false;

            MessageBox.Show(b.ToString());
        }

        /* GetValueOrDefault method of a nullable type 
           if the value is not null returns its value, else returns a default value */
        private void button4_Click(object sender, EventArgs e)
        {
            bool? a = null;
            bool b = a.GetValueOrDefault();

            MessageBox.Show(b.ToString());
        }

        /* operators: any valid operator for the underying type is considered legal
           but if any of the operands is null the whole expression returns null */
        private void button5_Click(object sender, EventArgs e)
        {
            int? x = 100;           

            // any valid operator may be used
            x++;
            x += 1;
            x /= 2;
            x = x * 2;

            MessageBox.Show(x.ToString());

            int? y = null;
            x = x + y + 20;              // if any of the operands is null, the result is null

            if (x.HasValue)
                MessageBox.Show(x.ToString());
            else
                MessageBox.Show("x = null");

        }

        /* Be carefull with boolean nullable types 
           and the & and | bitwise operators that used with boolean operands.
           If only a single operand is null the whole expession returns false       
         */
        private void button6_Click(object sender, EventArgs e)
        {
            bool? b = null;

            /* none of the message boxes is displayed here, 
               because one of the operands is null, both statements return false
             */
            if ((true & b) == false)
                MessageBox.Show("false");
            else if ((true & b) == true)
                MessageBox.Show("true");


            bool x = (true & b) == true;


            /* normal treatment of a nullable type and boolean operators */
            if ((b.HasValue) && ((bool)b))
                MessageBox.Show("true");
 
        }

        /* the ?? operator */
        private void button7_Click(object sender, EventArgs e)
        {
            int? x = null;
            int y = x ?? 123;

            MessageBox.Show(y.ToString());

            bool? a = null;
            bool b = a ?? false;

            MessageBox.Show(b.ToString());


        }
    }
}
