using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Lessons
{
    /* 
      A typical program source 
      A C# application is a group of types, that is classes, structs, enums etc.
      A class is simply a group of methods and properties
      The syntax for a class is
       class ClassName
      {
      
      }
     */
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
