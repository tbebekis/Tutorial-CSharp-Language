using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* Interfaces */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        /* An interface is not directly instantiated. Instead you create 
           an object that implements an interface and then assign an 
           interface variable */
        private void button1_Click(object sender, EventArgs e)
        {
            ICarDriver Driver = new Doctor(textBox1.Text);
            TestDriver(Driver);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ICarDriver Driver = new Teacher(textBox1.Text);
            TestDriver(Driver);
        }

        /* An object may assigned to an interface variable if its type (class or struct)
          implements the interface of that interface variable. */
        private void button3_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor("ABC 123");
            Teacher teacher = new Teacher("DEF 456");

            ICarDriver[] drivers = new ICarDriver[] { doctor, teacher };

            foreach (ICarDriver driver in drivers)
                TestDriver(driver);
        }

        /* It is not possible to directly call members of the implementor object 
           that are not members of the interface, through an interface variable 
           without a proper typecasting
        */
        public void TestDriver(ICarDriver Driver)
        {
            Driver.Drive();
            MessageBox.Show(Driver.LisenceNumber);

            Type T = Driver.GetType();
            MessageBox.Show(T.FullName);

            if (Driver is Doctor)
                (Driver as Doctor).Operate();
            else if (Driver is Teacher)
                ((Teacher)Driver).Teach();
        }
    }
}



namespace Lessons
{
    /* An interface declaration resembles a class declaration. 
       An interface may contain methods, properties and events but no fields. 
       It provides no implementation for any of its members.
       The implementation of the methods and properties is done in the class or struct
       that implements the interface.
       All interface members are considered public. Thus it is not valid to
       define accesibility for interface members.
     */
    public interface ICarDriver
    {
        void Drive();

        string LisenceNumber { get; set; }
    }


    /* A class may implement one or more interfaces.
       If a class inherits another class and implements interfaces at the same time
       the base class must come first in the ancestor list.
         class SomeClass: BaseClass, IInterface1, IInterface2
         {
         }
       A class that implements interfaces, it must implement all the methods
       and properties of all the interfaces it implements.
       A class that implements interfaces it may contains other methods or properties
       not found in any of the interfaces it implements.
     */
    class Doctor : ICarDriver
    {
        private string lisenceNumber = "";

        public Doctor(string LisenceNumber)
        {
            this.lisenceNumber = LisenceNumber;
        }

        public void Operate()
        {
            MessageBox.Show("Doctor is operating");
        }

        public void Drive()
        {
            MessageBox.Show("Doctor is driving his car");
        }

        public string LisenceNumber
        {
            get { return lisenceNumber; }
            set { lisenceNumber = value; }
        }
    }

    class Teacher : ICarDriver
    {
        private string lisenceNumber = "";

        public Teacher(string LisenceNumber)
        {
            this.lisenceNumber = LisenceNumber;
        }

        public void Teach()
        {
            MessageBox.Show("Teacher is teaching a class");
        }

        public void Drive()
        {
            MessageBox.Show("Teacher is driving his car");
        }

        public string LisenceNumber
        {
            get { return lisenceNumber; }
            set { lisenceNumber = value; }
        }
    }
}