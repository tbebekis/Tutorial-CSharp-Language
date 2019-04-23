using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using Lessons.Extensions;   // import the namespace where extension methods reside 


/* Extension methods */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* Although extension methods are declared as static they called as if they were instance methods */
        private void button1_Click(object sender, EventArgs e)
        {
            string S = "I like extension methods";
            IList list = S.ToList(' ');             // an extension method is called as if it was an instance method

            string S2 = "";
            foreach (string s in list)
                S2 += s + Environment.NewLine;

            MessageBox.Show(S2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temperature t = new Temperature(0);
            double d = t.AsFahrenheit();            // calling an extension method of a custom class
            MessageBox.Show(d.ToString());
        }
    }
}


namespace Lessons
{
    public struct Temperature  
    {
        public Temperature(double Value)
        {
            this.Value = Value;
        }

        public double Value;

    }
}

namespace Lessons.Extensions
{

    /* Extension methods are static methods that extend classes, structs or interfaces.
       Extension methods have at least a single parameter which determines the type they extend. 
       That special parameter should be the first one in the parameter list 
       and it should be prefixed by the keyword this */
    static public class Extensions
    {
        static public IList ToList(this string S, char Separator)
        { 
            string[] a = S.Split(new char[] { Separator } );
            IList list = new ArrayList(a);
            return list;
        }

        static public double AsFahrenheit(this Temperature temperature)
        {
            return ((temperature.Value * 9) / 5) + 32;
        }

        static public double AsKelvin(this Temperature temperature)
        {
            return temperature.Value + 273.15;
        }
    }
}