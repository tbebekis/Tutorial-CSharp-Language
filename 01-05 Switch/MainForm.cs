using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* switch statement  */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }


        /* switch statement  */
        private void button1_Click(object sender, EventArgs e)
        {
            int Value = int.Parse(textBox1.Text);
            string S = "";

            switch (Value)
            {
                case 1 :
                    S = Value.ToString();
                    break;
                case 2 :
                case 3 :
                    S = "Value is 2 or 3";
                    break;
                default:
                    {
                        if (Value <= 0)
                            S = "Value lesser or equal to zero";
                        else
                            S = "Value greater or equal to 4";
                        break;
                    }
            }

            MessageBox.Show(S);
        }

        /* switch statement with a string */
        private void button2_Click(object sender, EventArgs e)
        {
            string Value = comboBox1.Text;
            string S = "";

            switch (Value)
            {
                case "one":
                    S = Value;
                    break;
                case "two":
                case "three":
                    S = "Value is two or three";
                    break;
                default:
                    {
                       S = "Value greater or equal to four";
                        break;
                    }
            }

            MessageBox.Show(S);
        }


    }
}
