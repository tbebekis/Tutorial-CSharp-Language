using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* static classes and members, singleton pattern and sealed classes */
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
            double WaterFreezingPoint = 0; // Celsius

            WaterFreezingPoint = TemperatureConverter.CelsiusToFahrenheit(WaterFreezingPoint);
            MessageBox.Show("Water freezing point. Fahrenheit: " + WaterFreezingPoint.ToString());

            WaterFreezingPoint = TemperatureConverter.FahrenheitToCelsius(WaterFreezingPoint);
            MessageBox.Show("Water freezing point. Celsius: " + WaterFreezingPoint.ToString());

            WaterFreezingPoint = TemperatureConverter.CelsiusToKelvin(WaterFreezingPoint);
            MessageBox.Show("Water freezing point. Kelvin: " + WaterFreezingPoint.ToString());


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Singleton.Instance.Exec();
        }
    }

}



namespace Lessons
{

    static public class TemperatureConverter
    {

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
    }



    public sealed class Singleton
    {
        static private Singleton instance = null;

        private Singleton()                     // a private constructor
        {
        }

        static public Singleton Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }

        public void Exec()
        {
            MessageBox.Show("executing");
        }

    }

}