using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* delegates
   declaring delegates
   calling delegates*/
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public delegate int CalculationDelegate(int x, int y);

        public int Add(int x, int y)
        {
            return x + y;
        }


        public void Calculate(CalculationDelegate Handler)
        {
            int i = Handler(3, 4);              // calling the delegate

            MessageBox.Show(i.ToString());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //CalculationDelegate d = new CalculationDelegate(Add); // it is the same as the following
            CalculationDelegate d = Add;


            int i = d(1, 2);                    // calling the delegate

            MessageBox.Show(i.ToString());

            Calculate(d);                       // passing a delegate value as a parameter
        }
    }

    
 
}
