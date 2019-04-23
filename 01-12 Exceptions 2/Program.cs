using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Threading;


namespace Lessons
{
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

            /* adding a main exception handler method which is going to handle any unhandled exception
               thrown from inside any of the UI threads, NOT any other thread */
            Application.ThreadException += new ThreadExceptionEventHandler(MainExceptionHandler);

            /* forcing all UI exceptions go throur the newly installed main exception handler */
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            Application.Run(new MainForm());
        }

        static void MainExceptionHandler(object sender, ThreadExceptionEventArgs e)
        {
            MessageBox.Show("Hi from MainExceptionHandler. An exception is thrown: " + Environment.NewLine + e.Exception.Message);
        }
    }
}
