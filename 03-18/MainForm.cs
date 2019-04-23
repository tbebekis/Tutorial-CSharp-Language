using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* partial classes and methods */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
 
    }

}


namespace Lessons
{
    public partial class PartialClass
    {
        private int x;

        public PartialClass()
        {
        }

        partial void PartialMethod();
    }

    public partial class PartialClass
    {
        public PartialClass(int X)
        {
            this.x = X;
        }

        partial void PartialMethod()
        {
            x++;
        }

        public int X
        {
            get { return x; }
        }
    }
}