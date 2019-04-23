using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* Constructors and the default constructor */
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
            Man M = new Man();
            M = new Man("John");
            M = new Man("John", 30);

            Teacher T = new Teacher();
            T = new Teacher("Jane");
        }
    }



    class Man
    {
        private string name = "";
        private int age = 0;

        public Man()
        {
            name = "no name";
            age = 0;
        }

        public Man(string Name)
            : this(Name, 30)
        {
        }

        public Man(string Name, int Age)
            : this()
        {
            name = Name;
            age = Age;
        }
    }

    class Teacher : Man
    {
        public Teacher()
            : base()
        {
        }

        public Teacher(string Name)
            : base(Name)
        {
        }
    }
}
