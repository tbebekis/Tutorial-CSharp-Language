#define LOCAL_CONDITION

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

/* Comments and preprocessor directives */

/*
 * this is a multiline comment
 * 
 */
namespace Lessons
{
    /// <summary>
    /// This is a great form class. 
    /// It actually is a rather simple empty and useless window
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>
        /// the constructor of the MainForm
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }


        /// <summary>
        /// Gets some info
        /// </summary>
        /// <param name="S">a string that...</param>
        /// <param name="Form">an instance of a Form class</param>
        /// <returns>a useless integer</returns>
        public int GetSomeInfo(string S, Form Form)
        {
            // TODO complete this method
            return 0;
        }

        #region Conditional Directives
        public string Exec()
        {
#if LOCAL_CONDITION
            return "LOCAL_CONDITION is defined";
#else
            return "LOCAL_CONDITION is NOT defined";
#endif
        }

        public string Exec2()
        {
#if GLOBAL_CONDITION
            return "GLOBAL_CONDITION is defined";
#else
            return "GLOBAL_CONDITION is NOT defined";
#endif
        }

        #endregion
    }
}
