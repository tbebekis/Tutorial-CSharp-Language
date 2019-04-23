using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* structs */
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
            Temperature A;                              // an uninitialized struct variable       

            //MessageBox.Show(A.ToString());            // Error : Use of unassigned local variable 'A'

            A.Value = 30;                               // a struct is initialized when all of its fields are initialized

            MessageBox.Show(A.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Temperature A = new Temperature();                  // a default constructor initializes fields to their default values

            A.Value = 30;

            Temperature B = new Temperature(30);

            if (A.CompareTo(B) == 0)            // a struct may implement interfaces and contain methods
                MessageBox.Show("A == B");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Temperature? A = null;                      // a struct may be declared as a nullable type

            Temperature B = new Temperature(30);
            A = B;                              // Assigning a struct variable to another copies field values from one struct to another.

            MessageBox.Show(A.ToString());
        }
    }
}






namespace Lessons
{
 
    
    /// <summary>
    /// Represents a temperature in Celsius scale.
    /// It implements the IComparable interface
    /// </summary>
    public struct Temperature : IComparable
    {
 

        public Temperature(double Value)
        {
            this.Value = Value;
        }

        static public double CelsiusToFahrenheit(double Value)
        {
            return ((Value * 9) / 5) + 32;
        }

        static public double FahrenheitToCelsius(double Value)
        {
            return ((Value - 32) * 5) / 9;
        }

        static public double CelsiusToKelvin(double Value)
        {
            return Value + 273.15;
        }

        static public double KelvinToCelsius(double Value)
        {
            return Value - 273.15;
        }


        public override string ToString()
        {
            return "Celsius: " + Value.ToString();
        }

        public int CompareTo(object obj)
        {
            if (obj is Temperature)
                return Value.CompareTo(((Temperature)obj).Value);
            else
                throw new ArgumentException();
        }

        public double Value;


        public double AsCelsius
        {
            get { return Value; }
        }

        public double AsFahrenheit
        {
            get { return CelsiusToFahrenheit(Value); }

        }

        public double AsKelvin
        {
            get { return CelsiusToKelvin(Value); }
        }






    }

 

}