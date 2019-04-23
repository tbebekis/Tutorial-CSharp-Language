using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  declaring, initializing and assigning variables and constants 
    block and scope
    common operators */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        const int MaxValue = 100;   // constant field declaration - constant fields are considered static

        /* declaring variables */
        private void btnDeclare_Click(object sender, EventArgs e)
        {
            int x;                  // no initialization
            int y = 5;              // initialization
            int i, j = 10;          // initialization of the last variable
            string S = "Csharp";

            int N = y + 20;         // initialization

            //S = x.ToString();     // compile-time ERROR: Use of unassigned local variable
            //S = i.ToString();     // compile-time ERROR: Use of unassigned local variable

            const int MinValue = 10;    // constant declaration

            if (MinValue > MaxValue)
                MessageBox.Show("MinValue > MaxValue");
        }

        /* a nested class. C# permits nested types in a class */
        class Test
        {
            public int i = 0;      // i is a field of the Test class
        }

        /* variable initialization */
        private void btnInitialize_Click(object sender, EventArgs e)
        {

            // value type initialization
            int x;                  // no initialization 
            x = 1;                  // now it's initialized
            int y = 5;              // explicit initialization by using a literal value
            int z = y;              // initialization by using another variable  
            int i = new int();      // default initialization of a value type by using the default constructor


            // reference type initialization
            Test T = new Test();    // in creating an object, a constructor call is always required
            Test T2 = T;            // T2 now points to the same object as T
            int[] a = new int[3];   // arrays are reference types, this creates an array object with all of its elements having a default initialization
 
        }

        /* a method imposes a block */
        private void btnBlockAndScope_Click(object sender, EventArgs e)
        {

            /* a block imposes a scope */

            int i = 0;

            {
                // child block. Code goes here
            }               

            {
                //int i = 0;  // compile-time ERROR: a child block can not have a variable with the same name as its parent block
            }

            // sibling block
            {
                int x = 0;
            }

            {
                int x = 0;
            }

        }

        /* increment and decrement operators */
        private void btnIncAndDec_Click(object sender, EventArgs e)
        {
            int x = 0;

            x = x + 1;
            x = x - 1;

            x++;                  // x = 1 now
            x--;                  // x = 0 now

            /* increment and decrement operators may precede the variable */
            ++x;
            --x;
            
            MessageBox.Show("x = " + x.ToString());

            // it first assigns y and then increments x
            int y = x++;
            MessageBox.Show("y = " + y.ToString() + ", x = " + x.ToString());

            // it first decrements x and then assigns y
            y = --x;
            MessageBox.Show("y = " + y.ToString() + ", x = " + x.ToString());


        }

        /* compound operators and modulo operator */
        private void btnCompoundOps_Click(object sender, EventArgs e)
        {
            int x = 5;
            int y = 3;

            y += x;
            MessageBox.Show("y = " + y.ToString());

            y -= x;
            MessageBox.Show("y = " + y.ToString());


            y *= 2;
            MessageBox.Show("y = " + y.ToString());

            y /= 2;
            MessageBox.Show("y = " + y.ToString());


            // modulo operator: The modulus operator computes the remainder after dividing its first  by its second operand
            y = 10 % 3;
            MessageBox.Show("y = " + y.ToString());
        }


    }
}
