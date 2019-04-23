using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* loops */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9 };
        int total = 0;


        // for loop
        private void button1_Click(object sender, EventArgs e)
        {
            total = 0;

            for (int i = 0; i < numbers.Length; i++)
                total = total + numbers[i];

            MessageBox.Show(total.ToString());
        }

        // while loop
        private void button2_Click(object sender, EventArgs e)
        {
            total = 0;
            int i = 0;

            while (i < numbers.Length)
            {
                total = total + numbers[i];
                i++;
            }

            MessageBox.Show(total.ToString());
        }

        // do-while loop
        private void button3_Click(object sender, EventArgs e)
        {
            total = 0;
            int i = 0;

            do
            {
                total = total + numbers[i];
                i++;
            } while (i < numbers.Length);

            MessageBox.Show(total.ToString());
        }

        // foreach-in loop
        private void button4_Click(object sender, EventArgs e)
        {
            total = 0;
            foreach (int n in numbers)
                total = total + n;

            MessageBox.Show(total.ToString());
        }


        // break and continue
        private void button5_Click(object sender, EventArgs e)
        {
            total = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                    continue;

                total = total + numbers[i];

                if (total > 20)
                    break;  
            }
                

            MessageBox.Show(total.ToString());
        }

        // for loop with no condition expression
        private void button6_Click(object sender, EventArgs e)
        {
            total = 0;

            for (int i = 0, j = 0; ; i++, j++)
            {
                total = total + (i * j);
                if (total > 100)
                    break;
            }

            MessageBox.Show(total.ToString());
        }

        // for loop with no expressions at all
        private void button7_Click(object sender, EventArgs e)
        {
            total = 0;
            int i = 0;   
            int j = 0;   
            // int i, j = 0; // alternativelly
     

            for (; ; )
            {
                i++;
                j++;
                total = total + (i * j);
                if (total > 100)
                    break;
            }

            MessageBox.Show(total.ToString());
        }

        // while infinite loop with break
        private void button8_Click(object sender, EventArgs e)
        {
            total = 0;
            while (true)
            {
                total++;
                if (total > 5)
                    break;
            }

            MessageBox.Show(total.ToString());
        }
    }
}
