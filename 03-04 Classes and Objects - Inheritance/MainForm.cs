using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/*
  Classes
 * Declaring classes
 * Creating objects
 * Inheritance
 
 
 */

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
            Teacher T = new Teacher();
            T.Name = "John";            // Name field, inherited from Man
            T.Speak();                  // Speak() method, inherited from Man
            T.Teach();                  // Teach() method, defined in Teacher
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Teacher T = new Teacher();
            Man M = T;                  // an object of a derived class can be assigned to a variable of any of its base classes

 
            //M.Teach();                // member not found error, Man class does not provide a Teach() method.
        }
    }


    class Man
    {
        public string Name;

        public void Speak()
        {
            MessageBox.Show("speaking");
        }
    }

    class Teacher : Man  // Teacher class inherits from Man class
    {
        public void Teach()
        {
            MessageBox.Show("teaching");
        }
    }
}
