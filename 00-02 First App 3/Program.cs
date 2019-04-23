using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Lessons
{
    /*  
      Main() may have arguments. 
      It is always an array of strings
      The application path is NOT passed as the first argument to Main()
  
      When debugging, define command line arguments in 
      Project | Properties | Debug | command line arguments
      or start the program using command prompt
     */
    static class Program
    {
        static void Main(string[] args)
        {
            /* Arrays, as any other type in .Net, have methods and properties
             * Length is a property of the Array class            
             */
            MessageBox.Show("Number of arguments passed in Main(): " + args.Length.ToString());

            /* if args is not empty then display the first argument */
            if (args.Length > 0)
                MessageBox.Show(args[0]);
        }
    }

 
}
