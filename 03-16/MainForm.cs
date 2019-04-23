using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/*  Object comparison */
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
            Temperature T1 = new Temperature(32);
            Temperature T2 = new Temperature(32);

            //if (T1 == T2)
            //    MessageBox.Show("T1 == T2");          // Error: Operator '==' cannot be applied to operands of type 'Lessons.Temperature' and 'Lessons.Temperature'

            if (object.Equals(T1, T2))
                MessageBox.Show("Equals(T1, T2) ");     // true

            if (T1.Equals(T2))
                MessageBox.Show("T1.Equals(T2)");       // true

        }



        private void button2_Click(object sender, EventArgs e)
        {
            Man M1 = new Man(32);
            Man M2 = new Man(32);

            if (M1 == M2)
                MessageBox.Show("M1 == M2");            // false         

            if (object.Equals(M1, M2))
                MessageBox.Show("Equals(M1, M2) ");     // false        

            if (M1.Equals(M2))
                MessageBox.Show("M1.Equals(M2)");       // false        
        }
    }
}



namespace Lessons
{
    public class Man
    {

        public Man(int Age)
        {
            this.Age = Age;
        }

        public int Age;
    }

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

        public override bool Equals(object obj)
        {
            if (obj == null)
                throw new ArgumentNullException("obj");

            if (obj is Temperature)
                return Value == ((Temperature)obj).Value;
            else
                return false;
        }

        public override int GetHashCode()
        {
            return Value.GetHashCode();
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