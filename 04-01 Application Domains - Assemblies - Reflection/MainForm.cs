using System;
using System.ComponentModel; 
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.IO;
 

/* Application domains, assemblies and reflection */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        Assembly LessonsAssembly;       // a reference for a dynamic loaded assembly

        private void MainForm_Load(object sender, EventArgs e)
        {            
            string FileName = @"..\..\..\Lessons\bin\debug\Lessons.dll";
            if (File.Exists(FileName))
                LessonsAssembly = Assembly.LoadFrom(FileName);      // load the Lessons.dll assembly dynamically 
        }
 
        private void button1_Click(object sender, EventArgs e)
        {
            Assembly A = Assembly.GetAssembly(this.GetType());      // a way to get the current assembly
            MessageBox.Show(A.ToString());

            A = Assembly.GetExecutingAssembly();                    // another way to get the current assembly
            MessageBox.Show(A.ToString());

            Type[] types = A.GetExportedTypes();                    // gets an array of all public types
            //Type[] types = A.GetTypes();                          // gets an array of all types

            string S = "";
            foreach (Type t in types)
                S += t.ToString() + Environment.NewLine;

            MessageBox.Show(S); 
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Type t = LessonsAssembly.GetType("Lessons.Item");       // get a type from the dynamically loaded assembly

            PropertyInfo[] props = t.GetProperties();               // get the properties of a type
            string S = "";
            foreach (PropertyInfo p in props)
                S += p.ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Type t = LessonsAssembly.GetType("Lessons.Item");       // get a type from the dynamically loaded assembly

            MethodInfo[] methods = t.GetMethods();                  // get the methods of a type
            string S = "";
            foreach (MethodInfo m in methods)
                S += m.ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Type t = LessonsAssembly.GetType("Lessons.Item");       // get a type from the dynamically loaded assembly

            ConstructorInfo ci = t.GetConstructor(new Type[] {typeof(string), typeof(double) });    // get a constructor of a type
            object o = ci.Invoke(new object[] {"Hard disk", 5 });   // invoke the constructor

            PropertyInfo pi = t.GetProperty("Name");                // get a property
            MessageBox.Show(pi.GetValue(o, null).ToString());       // display its value

            pi = t.GetProperty("Price");
            MessageBox.Show(pi.GetValue(o, null).ToString());

            pi = t.GetProperty("Name");
            pi.SetValue(o, "Mouse", null);                          // set the value of a property
            MessageBox.Show(pi.GetValue(o, null).ToString());       // display its value

            MethodInfo mi = t.GetMethod("IncreasePriceBy");         // get a method
            mi.Invoke(o, new object[] { 10 });                      // invoke the method, the method affects the Price property

            pi = t.GetProperty("Price");
            MessageBox.Show(pi.GetValue(o, null).ToString());       // display the value of the Price property

        }

    }
}


 