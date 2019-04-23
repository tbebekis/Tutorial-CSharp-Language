using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


[assembly: CLSCompliant(true)]


/* Attributes */
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
            CodeHistoryAttribute a = (CodeHistoryAttribute)Attribute.GetCustomAttribute(typeof(Demo), typeof(CodeHistoryAttribute));

            string S = "Developer: " + a.Developer + Environment.NewLine +
                       "Revision: " + a.Revision + Environment.NewLine +
                       "Comments: " + a.Comments;

            MessageBox.Show(S);
                        

        }
    }
}


namespace Lessons
{
    //[FlagsAttribute()]
    //[FlagsAttribute]
    //[Flags()]
    [Flags]
    enum Day { Sun = 0, Mon = 1, Tue = 2, Wed = 4, Thu = 8, Fri = 16, Sat = 32 };

  
    public class UselessComponent : Component
    {
        [Browsable(false)]
        public int UselessProperty { get; set; }

        [Browsable(true)]
        public string Name { get; set; }
    }



    [AttributeUsage(AttributeTargets.All, AllowMultiple = true, Inherited = true)]
    public class CodeHistoryAttribute : Attribute
    {
        private string developer;
        private string revision; 
        
        public CodeHistoryAttribute(string Developer, string Revision)
        {
            this.developer = Developer;
            this.revision = Revision;
        }

        public string Developer { get { return developer; } }
        public string Revision { get { return revision; } }
        public string Comments { get; set; } 
    }


    [CodeHistory("teo", "1.0", Comments = "this is the initial version")]
    public class Demo
    {
        public void Exec()
        {
        }
    }
}
