using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* using multicast delegates */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public delegate void CalculationDelegate(int x, int y);

        public void Add(int x, int y)
        {
            int Res = x + y;

            MessageBox.Show(Res.ToString());
        }

        public void Subtract(int x, int y)
        {
            int Res = x - y;

            MessageBox.Show(Res.ToString());
        }

        public void Multiply(int x, int y)
        {
            int Res = x * y;

            MessageBox.Show(Res.ToString());
        }

        public void Divide(int x, int y)
        {
            int Res = x / y;

            MessageBox.Show(Res.ToString());
        }

        /* multicast delegates */
        private void button1_Click(object sender, EventArgs e)
        {
            CalculationDelegate d = Add; 
       
            d += Subtract;

            CalculationDelegate c = Multiply;
            d += c;

            CalculationDelegate f = Divide;
            d = d + f;
       
            d(10, 2);

            MessageBox.Show(d.GetType().BaseType.FullName);

            d = d - f;

            int i = d.GetInvocationList().GetLength(0);
            MessageBox.Show(i.ToString());
        }
 
    }
}
