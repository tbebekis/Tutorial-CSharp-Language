using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* arrays */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        void DisplayArray(int[] A)
        {
            string S = "";
            
            foreach (int i in A)
                S = S + i.ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }


        /* An array passed to a method is a reference to an 
           array instance, NOT a copy of the array.            
           Changes to the passed array are propagated outside the method */
        void AlterArray(int[] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
                A[i] *= 2;
        }

        int[] CreateArray()
        {
            //int[] numbers = new int[5] { 1, 2, 3, 4, 5 };   // alternative syntax of the following
            //int[] numbers = new int[] { 1, 2, 3, 4, 5 };    // alternative syntax of the following
            //int[] numbers = { 1, 2, 3, 4, 5 };              // alternative syntax of the following

            int[] numbers;
            numbers = new int[5];

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            return numbers;
        }


        /* creating, altering, displaying and passing an array to a method */
        private void button1_Click(object sender, EventArgs e)
        {
            int[] numbers = CreateArray();

            DisplayArray(numbers);
            AlterArray(numbers);
            DisplayArray(numbers);
        }

        /* a string array */
        private void button2_Click(object sender, EventArgs e)
        {
            string[] A = { "C#", "is", "a", "great", "language" };

            string Text = "";

            foreach (string S in A)
                Text = Text + ' ' + S;

            MessageBox.Show(Text);


            /* getting the index of an array element */
            int i = Array.IndexOf(A, "great");
            MessageBox.Show("great is in the element at index " + i.ToString());

        }

        /* sorting an array */
        private void button3_Click(object sender, EventArgs e)
        {
            char[] A = { 'c', 'B', 'A', 'b', 'C', 'a'};
            Array.Sort(A);

            string S = "";
            foreach (char c in A)
                S = S + c.ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }

        /* un-initialized string array, elements are empty strings, not null */
        private void button4_Click(object sender, EventArgs e)
        {
            string[] A = new string[2];

            string S = A[0] + A[1];

            MessageBox.Show(S);

        }

        /*Assigning an array variable to another makes both variables pointing
            to the same array instance (object) in memory */
        private void button5_Click(object sender, EventArgs e)
        {
            int[] A = { 1, 2, 3, 4, 5 };
            int[] B = A;

            AlterArray(B);
            DisplayArray(A);
            
        }

        
    }
}
