using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* 
 Hiding members in derived classes
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
            Man man = new Man();
            man.SayGoodMorning();

            Italian italian = new Italian();
            italian.SayGoodMorning();

 
            man = italian;
            man.SayGoodMorning();           // the version of the method to call is determined by the type of the variable 
        }

        private void button2_Click(object sender, EventArgs e)
        {
 
        }
    }


 
    public class Man
    {
        public void SayGoodMorning()
        {
            MessageBox.Show("good morning");
        }
    }

    public class Italian: Man
    {
        new public void SayGoodMorning()    // the new keyword suppresses the warning
        {
            base.SayGoodMorning();          // the base keyword is used to call an inherited member
            MessageBox.Show("buon jorno");
        }
    }






}
