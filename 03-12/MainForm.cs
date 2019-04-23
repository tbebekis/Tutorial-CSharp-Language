using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
/* 
 * Polymorphism, virtual and override methods and properties
 * the new keyword and method hiding
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
            Italian italian = new Italian();
            French french = new French();
            German german = new German();

            Man[] men = new Man[] { italian, french, german };

            foreach (Man m in men)
                m.SayGoodMorning();                 // a polymorphic call

            foreach (Man m in men)
                MessageBox.Show(m.GetCountry());    // non-polymorphic call

            MessageBox.Show(italian.GetCountry());  // non-polymorphic call
            MessageBox.Show(french.GetCountry());   // non-polymorphic call
            MessageBox.Show(german.GetCountry());   // non-polymorphic call

            MessageBox.Show(((Man)german).GetCountry());    // calling the base non-polymorphic method


   
        }
    }

    public class Man
    {
        public virtual void SayGoodMorning()
        {
        }

        public string GetCountry()
        {
            return "unknown";
        }
    }

    public class Italian : Man
    {
        public override void SayGoodMorning()
        {
            MessageBox.Show("buon jorno");
        }

        new public string GetCountry()
        {
            return "Italy";
        }
    }

    public class French : Man
    {
        public override void SayGoodMorning()
        {
            MessageBox.Show("bon jour");
        }

        new public string GetCountry()
        {
            return "France";
        }
    }

    public class German : Man
    {
        public override void SayGoodMorning()
        {
            MessageBox.Show("guten morgen");
        }

        new public string GetCountry()
        {
            return "Deutschland";
        }
    }

}
