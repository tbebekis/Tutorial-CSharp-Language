using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* overloaded methods - the params keyword */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* overloaded method */
        public void Display(string Text)
        {
            MessageBox.Show(Text);
        }

        /* overloaded method */
        public void Display(string Text, int Param)
        {
            Display(Text + ": " + Param.ToString());
        }

        /* calling an overloaded method */
        private void button1_Click(object sender, EventArgs e)
        {
            Display("Total value", 123);
        }

        /* the keyword params */
        public void Exec(params object[] a)
        {
            string Text = "";
            foreach (object o in a)
                Text += o.ToString() + Environment.NewLine;

            MessageBox.Show(Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Exec("Today is ", DateTime.Today);
        }
    }
}
