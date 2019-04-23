using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* nested types */
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
            Outer.Inner inner = new Outer.Inner();
            Outer.InnerEnum ie = Outer.InnerEnum.a;
        }
    }
}


namespace Lessons
{
    public class Outer
    {
        public enum InnerEnum { a, b, c };      // nested enum type
        public delegate void InnerDelegate();   // nested delegate type

        public class Inner                      // nested class type
        {
            private int x = 0;
            private Outer outer;

            public Inner()
            {
            }

            public Inner(Outer Outer)
            {
                this.outer = Outer;
                outer.x = 1;    // inner types can access private or protected members of outer types
            }
        }


        private int x = 0;
        private Inner inner;

        public Outer()
        {
            inner = new Inner(this);
            //inner.x = 1;          // Error: outer types can not access private or protected members of inner types
        }

        public Inner InnerObject
        {
            get { return inner; }
        }
    }
}