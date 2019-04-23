using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* Iterators */
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
            WordList list = new WordList();
            
            string S = "";

            foreach (string word in list)
                S += word + " ";

            MessageBox.Show(S);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NumberList list = new NumberList();

            int sum = 0;

            foreach (int i in list)
                sum += i;

            MessageBox.Show(sum.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonList persons = new PersonList();

            string S = "";
            foreach (Person p in persons)
                S += p.ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            GenericList persons = new GenericList();

            string S = "";
            foreach (Person p in persons)
                S += p.ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MultiList multiList = new MultiList();

            string S = "";

            foreach (string word in multiList.GetWords())
                S += word + " ";

            MessageBox.Show(S);

             

            int sum = 0;

            foreach (int i in multiList.GetNumbers(3, 6))
                sum += i;

            MessageBox.Show(sum.ToString());


            S = "";
            foreach (Person p in multiList.GetPersons())
                S += p.ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }
    }
}


namespace Lessons
{

    
    /* a helper class to be used as "element" */
    public class Person
    {
        public Person(): this("John Doe")
        {
        }

        public Person(string Name)
        {
            this.Name = Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public string Name { get; set; }
    }


    /* a class that provides an iterator without any array or collection */
    public class WordList
    {
        public IEnumerator GetEnumerator()
        {
            yield return "C#";
            yield return "is";
            yield return "a";
            yield return "great";
            yield return "language";
        }
    }
    
    /* a typical class with an iterator */
    public class NumberList
    {
        int[] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9 };


        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                yield return numbers[i]; 
            }
        }
    }


    /* a class with an iterator which uses the Person class as an element */
    public class PersonList 
    {
        ArrayList persons = new ArrayList { new Person("John Doe"), new Person("Jane Doe") };

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                yield return persons[i];
            }
        }
    }

    /* a class with an iterator which uses the Person class as an element or an IEnumerator<T> */
    public class GenericList
    {
        ArrayList persons = new ArrayList { new Person("John Doe"), new Person("Jane Doe") };

        public IEnumerator<Person> GetEnumerator()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                yield return (Person)persons[i];
            }
        }
    }


    /* a class implementing multiple iterators */
    public class MultiList 
    {
        string[] words = {"C#", "is", "a", "great", "language"  };
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        ArrayList persons = new ArrayList { new Person("John Doe"), new Person("Jane Doe") };

        public IEnumerable GetWords()
        {
            for (int i = 0; i < words.Length; i++)
            {
                yield return words[i];
            }
        }

        public IEnumerable GetNumbers(int StartIndex, int EndIndex)
        {
            for (int i = StartIndex; i <= EndIndex; i++)
            {
                yield return numbers[i];
            }
        }

        public IEnumerable GetPersons()
        {
            for (int i = 0; i < persons.Count; i++)
            {
                yield return persons[i];
            }
        }
    }

}
            