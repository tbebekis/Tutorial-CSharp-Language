using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* value type variables and reference type variables */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

       

        /* this is an event handler method, it handles the Click event of the button */
        private void btnValueTypes_Click(object sender, EventArgs e)
        {
            /* value type variables */
            int i = 1;
            int j = i;

            i = 2;

            /* Each value type variable has its own copy of data */
            MessageBox.Show(j.ToString());
            MessageBox.Show(i.ToString());

        }

        /* a nested class. C# permits nested types in a class */
        class Test
        {
            public int i = 0;           // i is a field of the Test class
            
        }

        private void btnRefTypes_Click(object sender, EventArgs e)
        {
            
            /* reference type variables */
            Test A = new Test();    // objects are always constructed by using the new operator and a constructor
            Test B = A;             // Two reference variables can reference the same object

            A.i = 2;                // Operations on one can affect another

            MessageBox.Show(A.i.ToString());
            MessageBox.Show(B.i.ToString());
        }

 
    }
}
