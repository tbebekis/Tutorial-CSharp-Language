using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* Implicitly Typed Local Variables  */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* declaring implicitly typed local variables */
        private void button1_Click(object sender, EventArgs e)
        {
            //var x; // Error: Implicitly-typed local variables must be initialized

            var i = 123;
            var s = "C sharp";
            var b = false;
            var d = 1.2;
            var a = new[] { 1, 2, 3 };
            var a2 = new[] { "Hi", "there" }; 


            MessageBox.Show(i.GetType().FullName);
            MessageBox.Show(s.GetType().FullName);
            MessageBox.Show(b.GetType().FullName);
            MessageBox.Show(d.GetType().FullName);
            MessageBox.Show(a.GetType().FullName);
            MessageBox.Show(a2.GetType().FullName);

        }

        /* using var in various statements */
        private void button2_Click(object sender, EventArgs e)
        {
            var total = 0;


            // in a for statement
            for (var i = 1; i < 10; i++)
                total += i;

            MessageBox.Show(total.ToString());


            // in a foreach statement
            int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9 };
            total = 0;
            foreach (var n in numbers)
                total += n;

            MessageBox.Show(total.ToString());


            /*
             in a using statement
             Graphics class wraps operating system resources.
             Graphics objects should be disposed after using them by
             calling Dispose(). The using statement calls Dispose() 
             automatically.
             */ 

            using (var G = Graphics.FromHwnd(this.Handle))
            {
                G.DrawString("Hi there", this.Font, SystemBrushes.WindowText, 0, 0);
            }
 

        }
    }

 
}
