using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* events */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Man M;

        private void MainForm_Load(object sender, EventArgs e)
        {
            M = new Man();
            M.NameChanged += Man_NameChanged; // subscribing to an event
            M.NameChanged += Man_NameChanged2;
        }

        public void Man_NameChanged(object sender, NameEventArgs e)
        {
            MessageBox.Show("Old name: " + e.OldName + ", New name: " + e.NewName);
        }

        public void Man_NameChanged2(object sender, NameEventArgs e)
        {
            MessageBox.Show("this is a second handler");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            M.Name = textBox1.Text;    // this change will trigger the event

            M.NameChanged -= Man_NameChanged2;
        }

    }

    /* An EventArgs descendant to be used with NameEventHandler events and delegates */
    public class NameEventArgs : EventArgs
    {
        private string oldName;
        private string newName;

        public NameEventArgs(string OldName, string NewName)
        {
            oldName = OldName;
            newName = NewName;
        }

        public string OldName { get { return oldName; } }
        public string NewName { get { return newName; } }
    }


    public delegate void NameEventHandler(object sender, NameEventArgs e);


    public class Man
    {
        private string name = "<no name>";

        protected void OnNameChanged(string OldName, string NewName)
        {
            if (NameChanged != null)
                NameChanged(this, new NameEventArgs(OldName, NewName));
        }

        public event NameEventHandler NameChanged;

        public string Name
        {
            get { return name; }
            set
            {
                if (name != value)
                {
                    OnNameChanged(name, value);
                    name = value;
                }
            }
        }
    }

    
}
