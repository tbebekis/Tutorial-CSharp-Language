using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* 
 * abstract classes and abstract methods 
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
            Vehicle V1 = new Airplane();
            Vehicle V2 = new Car();

            MessageBox.Show(V1.Move());
            MessageBox.Show(V2.Move()); 
        }
    }


    /* a small hierarcy of different vehicles */
    public abstract class Vehicle
    {
        public abstract string Move();
        public abstract int Weight { get; }
    }

    public class Airplane : Vehicle
    {
        public override string Move()
        {
            return "Airplane is flying";
        }

        public override int Weight { get { return 12000; } }
    }

    public abstract class Wheeled : Vehicle
    {
        public override string Move()
        {
            return "Wheeled is moving";
        }
    }

    public class Car : Wheeled
    {
        public override string Move()
        {
            string Result = base.Move();
            return Result + " -- Car is speeding up";
        }

        public override int Weight { get { return 1500; } }
    }


}
