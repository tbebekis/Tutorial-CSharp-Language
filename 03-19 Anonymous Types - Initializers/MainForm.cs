using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;


/*  Anonymous types - Object and collection initializers */
namespace Lessons
{
    public partial class MainForm : Form
    {
      

        public MainForm()
        {
            InitializeComponent();
        }

        public class Man
        {
            public string Name;
            public int Age;
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            var m = new { Name = "John", Age = 32 };    // anonymous type

            MessageBox.Show(m.Name);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Man m = new Man { Name = "John", Age = 32 };    // object initializer

            MessageBox.Show(m.Name);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Man[] men = new Man[]                       // initializing an array                             
            {
                new Man { Name = "John", Age = 32 },
                new Man { Name = "Jane", Age = 30 },
                null
            };

            MessageBox.Show(men[1].Name);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var men = new[]                             // initializing an anonymous array                             
            {
                new Man { Name = "John", Age = 32 },
                new Man { Name = "Jane", Age = 30 },
                null
            };

            MessageBox.Show(men[1].Name);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ArrayList men = new ArrayList              // initializing list     
            {
                new Man { Name = "John", Age = 32 },
                new Man { Name = "Jane", Age = 30 },
                null
            };

            MessageBox.Show(((Man)men[1]).Name);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            List<Man> men = new List<Man>               // initializing generic list  
            {
                new Man { Name = "John", Age = 32 },
                new Man { Name = "Jane", Age = 30 },
                null
            };

            MessageBox.Show(men[1].Name);
        }
    }
}
