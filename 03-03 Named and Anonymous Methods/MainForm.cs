using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* named and anonymous methods */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public delegate void StringDelegate(string Text);

        public void Display(string S)
        {
            MessageBox.Show("Named method: " + S);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // a named method
            StringDelegate d = Display;

            // an anonymous method
            d += delegate(string S) 
                    {
                        MessageBox.Show("Anonymous method: " + S); 
                    };

            d("Hi there!");
        }
    }
}
