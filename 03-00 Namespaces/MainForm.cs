using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Lessons.Classes;        // importing a namespace


/* namespaces */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void DisplayFullName(BaseClass instance)
        {
            instance.DisplayFullName();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            DisplayFullName(new BaseClass());
            DisplayFullName(new SomeClass());

            DisplayFullName(new namespaceA.SomeClass());
            DisplayFullName(new namespaceB.SomeClass());

 

        }
    }
}
