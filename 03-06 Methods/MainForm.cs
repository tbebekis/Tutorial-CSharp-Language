using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* methods, parameters and passing parameters */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        public int Add(int x, int y)
        {
            return x + y;
        }

        public void Exec()
        {
            MessageBox.Show("Exec()");
            return;
            MessageBox.Show("this will not be reached");    // compiler warning: unreachable code detected
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int i = Add(2, 5);
            MessageBox.Show(i.ToString());

            Exec();
        }

        public void PassByValue(int x)
        {
            x++;
        }

        public void PassByRef(ref int x)
        {
            x++;
        }


        /* passing value type parameters */
        private void button2_Click(object sender, EventArgs e)
        {
            int x = 1;              // must be initialized if is to be passed by ref

            PassByValue(x);         // x remains 1 here
            MessageBox.Show(x.ToString());

            PassByRef(ref x);           // x is 2 here
            MessageBox.Show(x.ToString());
        }


        public class Man            // nested class 
        {
            public string Name = "John";
        }

        public void ManByValue(Man M)
        {
            //M = new Man();      // this object is discarded upon method exit
            M.Name = "Jane";
        }

        public void ManByRef(ref Man M)
        {
            M = new Man();      // this object is propagated outside the method
            M.Name = "Jane";
        }

        /* passing reference type parameters */
        private void button3_Click(object sender, EventArgs e)
        {
            Man M = new Man();

            MessageBox.Show(M.GetHashCode().ToString());

            ManByValue(M);
            MessageBox.Show(M.Name);
            MessageBox.Show(M.GetHashCode().ToString());    // hash code is the same here even if we create a new Man inside the ManByValue()


            ManByRef(ref M);
            MessageBox.Show(M.Name);        
            MessageBox.Show(M.GetHashCode().ToString());    // a new hash code here, the change is propagated      
        }


        public void StrOut(out string S)
        {
            S = "out parameter: Hi there!";            // out parameters must initialized before exit
        }

        /* passing reference type parameters - using out */
        private void button4_Click(object sender, EventArgs e)
        {
            string S;
            StrOut(out S);              // out parameters require no initialization
            MessageBox.Show(S);
        }


    }

 

}
