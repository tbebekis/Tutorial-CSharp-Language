using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* exceptions, catching and throwing exceptions, user defined exceptions
   try-catch blocks
   try-catch-finally blocks 
   try-finally blocks */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int x = 1;
        int y = 0;


        /* a simple try/catch with the most general error trap */
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {   
                x = x / y;                      // generates an exception
                MessageBox.Show(x.ToString());  // this line wont execute
            }
            catch                               // this traps exceptions of any kind
            {
                MessageBox.Show("something bad happened");
            }
        }

        /* same as above */
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                x = x / y;
                MessageBox.Show(x.ToString());   
            }
            catch (Exception Ex)                // this is the most general trap
            {
                MessageBox.Show(Ex.Message);
            }
        }

        /* it is possible to have multiple catch parts
           to trap different kind of specific exceptions.
           In that case the most general trap goes to the end  
         */
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                x = x / y;
                MessageBox.Show(x.ToString());
            }
            catch (OverflowException Ex)        // wrong trap, it's a division by zero
            {
                MessageBox.Show(Ex.Message);
            }
            catch (ArithmeticException Ex)      // ok, division by zero is an arithmetic exception
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)                // this is the most general trap
            {
                MessageBox.Show(Ex.Message);
            }

        }

        /* placing the right trap */
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                x = x / y;
                MessageBox.Show(x.ToString());
            }
            catch (DivideByZeroException Ex)         
            {
                MessageBox.Show(Ex.Message);
            }
            catch (Exception Ex)                // this is the most general trap
            {
                MessageBox.Show(Ex.Message);
            }
 
        }

        /* re-throwing an exception */
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                x = x / y;
                MessageBox.Show(x.ToString());
            }
            catch (Exception Ex)                // this is the most general trap
            {
                MessageBox.Show(Ex.Message);    // handle the exception
                throw;                          // re-throw the exception
            }
        }

        /* explicitly throwing an exception */
        void HandleObject(object Instance)
        {
            if (Instance == null)
                throw new ArgumentNullException("Instance");
            MessageBox.Show(Instance.ToString());
        }

        /* handling an explicitly thrown exception */
        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                HandleObject(null);     // it always generates an exception
            }
            catch (Exception Ex)                
            {
                MessageBox.Show(Ex.Message);     
            }
        }

        /*
          using a try/finally block.
          Graphics class wraps operating system resources.
         */
        private void button7_Click(object sender, EventArgs e)
        {
            Graphics G = Graphics.FromHwnd(this.Handle);
            try
            {
                G.DrawString("Hi there", this.Font, SystemBrushes.WindowText, 0, 0);
                x = x / y;
            }
            catch (Exception Ex)    // it is not required to have a catch part in a try-finally block
            {
                MessageBox.Show(Ex.Message);
            }
            finally                 // always executes, even if an exception is thrown inside the guarded try block 
            {
                G.Dispose();
            }
        }

        /* throwing a user defined exception */
        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                throw new UserDefinedException("this is a user defined exception");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
 
    }

    /* a user defined exception class */
    public class UserDefinedException : Exception
    {
        public UserDefinedException(string message)
            : base(message)
        {
        }

    }
}
