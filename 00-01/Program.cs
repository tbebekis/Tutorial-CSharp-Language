using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;


namespace Lessons
{
    /* 
      The Program name is not mandatory 
      C# is case sensitive
      Main() is a case sensitive name
      Main() should be a public static method
      It is possible to have more than one Main() methods
      When more than one classes exist containing a Main(), define the StartUp 
      object in Project | Properties | Application | Startup object.
      If you don't you get a compile time error.
      When Main() ends the application terminates.

     */
    static class ClassA
    {
        static void Main()
        {
            MessageBox.Show("ClassA Main()");
        }
    }

    static class ClassB
    {
        static void Main()
        {
            MessageBox.Show("ClassB Main()");

            /* You can refer to classes by using full qualified names,
             * that is the namespace they belong to.
             * You can omit the namespace infront of a class name
             * when the namespace is imported by the using directive
             */
            System.Windows.Forms.MessageBox.Show("Hi there!");

        }
    }
}
