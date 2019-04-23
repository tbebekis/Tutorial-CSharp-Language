using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* Operator overloading */
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
            Temperature T1 = new Temperature(TemperatureKind.Celsius, 0);
            Temperature T2 = new Temperature(TemperatureKind.Celsius, 1);

            if (T1 == T2)
                MessageBox.Show("T1 == T2");
        }
    }
}


namespace Lessons
{

    public enum TemperatureKind
    {
        Celsius,
        Fahrenheit,
        Kelvin
    }

    public struct Temperature
    {
        public Temperature(double Value)
            : this(TemperatureKind.Celsius, Value)
        {
        }

        public Temperature(TemperatureKind Kind, double Value)
        {
            this.Value = Value;
            this.Kind = Kind;
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

        public double Value;
        public readonly TemperatureKind Kind;

        public override bool Equals(object obj)
        {
            if (obj != null)
                throw new ArgumentNullException("obj");

            if (obj is Temperature)
                return (Value == ((Temperature)obj).Value) && (Kind == ((Temperature)obj).Kind);
            else
                return false;
        }

        public override int GetHashCode()
        {
            return (Value.ToString() + "|" + Kind.ToString()).GetHashCode();
        }

        public static bool operator ==(Temperature T1, Temperature T2)
        {

            return (T1.Value == T2.Value) && (T1.Kind == T2.Kind);
        }

        public static bool operator !=(Temperature T1, Temperature T2)
        {
            return (T1.Value != T2.Value) || (T1.Kind != T2.Kind);
        }

    }
}