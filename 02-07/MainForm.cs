using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;



/* lists and collections (non generic) */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Display(IEnumerable E)
        {
            string S = "";
            foreach (object o in E)
                S += o.ToString() + Environment.NewLine;
            MessageBox.Show(S);
        }


        /* ArrayList class */
        private void button1_Click(object sender, EventArgs e)
        {
            string[] a = new string[] {"C sharp", "is", "a", "great", "language" };
            ArrayList list = new ArrayList(a);      // create an ArrayList passing an ICollection, arrays implement ICollection

            Display(list);                          // ArrayList implements IEnumerable

            list.Sort();                            // Sort() the list
            Display(list);

            Display(list.ToArray());                // ToArray(), arrays implement IEnumerable     

            list.Insert(0, 1);                      // using the Insert() method
            list.Insert(2, 2);
            list.Insert(4, 3);
            list.Insert(6, 4);
            list.Insert(8, 5);

            Display(list);

            int i = list.IndexOf("great");          // IndexOf()

            MessageBox.Show("great is at index: " + i.ToString());

            list.RemoveAt(8);                       // RemoveAt()
            list.RemoveAt(6);
            list.Remove(3);                         // Remove()
            list.Remove(2);
            list.Remove(1);

            Display(list);

            list.Clear();                           // Clear()

            list.Add("C sharp");                    // Add()
            list.Add("is");
            list.Add("a");
            list.Add("great");
            list.Add("language");

            Display(list);

        }

        /* Hashtable class */
        private void button2_Click(object sender, EventArgs e)
        {
            Hashtable ht = new Hashtable();

            ht.Add("Hard disk", 19.90);
            ht.Add("Mouse", 5.90);
            ht.Add("Monitor", 120.50);

            MessageBox.Show(ht["Mouse"].ToString());

            foreach (DictionaryEntry de in ht)
                MessageBox.Show(de.Key.ToString() + ": " + de.Value.ToString());
        }

        /* SortedList class */
        private void button3_Click(object sender, EventArgs e)
        {
            SortedList sl = new SortedList();

            sl.Add("Rome", 1);
            sl.Add("London", 2);
            sl.Add("Athens", 3);
            sl.Add("Madrid", 4);
            sl.Add("Berlin", 5);

            // SortedList is a dictionary
            foreach (DictionaryEntry de in sl)
                MessageBox.Show(de.Key.ToString() + ": " + de.Value.ToString());


            string S = "";


            // SortedList elements are accessible by index too, not key only
            for (int i = 0; i < sl.Count; i++)
                S += sl.GetKey(i).ToString() + ": " + sl.GetByIndex(i).ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }

        /* Queue class and Stack class */
        private void button4_Click(object sender, EventArgs e)
        {
            string S = "";

            Queue q = new Queue();

            q.Enqueue("C sharp");                  
            q.Enqueue("is");
            q.Enqueue("a");
            q.Enqueue("great");
            q.Enqueue("language");

            while (q.Count > 0)
                S += q.Dequeue().ToString() + Environment.NewLine;

            MessageBox.Show(S);

            Stack st = new Stack();
            st.Push("C sharp");
            st.Push("is");
            st.Push("a");
            st.Push("great");
            st.Push("language");

            S = "";
            while (st.Count > 0)
                S += st.Pop().ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }
    }
}
