using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* Heap, stack and recursive calls */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* set a breakpoint into this method and use F10 to watch the call stack in the call stack window */
        void RecursiveMethod(int x)
        {
            if (x > 5)
                return;

            x++;

            RecursiveMethod(x);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 0;
            RecursiveMethod(x);
        }
    }
}
