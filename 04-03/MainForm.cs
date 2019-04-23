using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* generics */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        /* a generic list */
        private void button1_Click(object sender, EventArgs e)
        {
            GenericList<string> list = new GenericList<string>();

            list.Add("C#");
            list.Add("generics");

            string S = "";

            for (int i = 0; i < list.Count; i++)
                S += list[i] + " ";

            MessageBox.Show(S);
        }

        /* the same generic list using an int type argument */
        private void button2_Click(object sender, EventArgs e)
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            int total = 0;

            for (int i = 0; i < list.Count; i++)
                total += list[i];

            MessageBox.Show(total.ToString());
        }

        /* BCL provides already a generic list: the List<T> class */
        private void button3_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            int total = 0;

            for (int i = 0; i < list.Count; i++)
                total += list[i];

            MessageBox.Show(total.ToString());
        }

        /* arrays with a lower bound of zero automatically implement the IList<T> generic interface.*/
        private void button4_Click(object sender, EventArgs e)
        {
            int[] a = { 0, 1, 2 };
            IList<int> list = a;

            int total = 0;

            for (int i = 0; i < list.Count; i++)
                total += list[i];

            MessageBox.Show(total.ToString());
        }

        /* a generic method - compiler type inference on generic type arguments */
        private void GenericMethod<T>(T x)
        {
            string S = x.GetType().Name + ": " + x.ToString();
            MessageBox.Show(S);
        }

        
        private void button5_Click(object sender, EventArgs e)
        {
            GenericMethod(123);
            GenericMethod(12.3);
            GenericMethod("123");
        }

        /* overloading a generice method */
        private void GenericMethod<T, T2>(T x, T2 y)
        {
            string S = x.GetType().Name + ": " + x.ToString() + Environment.NewLine +
                       y.GetType().Name + ": " + y.ToString();
            MessageBox.Show(S);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int a = 123;
            string b = "generics";

            GenericMethod(a, b);
        }


        /* Constraints on generic type parameters
           The Sorter generic class is defined as 
             class Sorter<T> where T : IComparable
             {...}  */
        private void button7_Click(object sender, EventArgs e)
        {
            GenericList<int> list = new GenericList<int>();

            list.Add(3);
            list.Add(1);
            list.Add(2);

            Sorter<int> sorter = new Sorter<int>();

            int[] elements = sorter.Sort(list);

            string S = "";

            foreach (int i in elements)
                S += i.ToString() + Environment.NewLine;

            MessageBox.Show(S);

        }

        /* to be used with delegates and events of type
           public delegate void GenericDelegate<T>(T sender); */
        void GenericHandler<T>(T sender)
        {
            MessageBox.Show(sender.ToString());     // only System.Object members are available to a generic parameter
        }

        /* to be used with delegates and events of type
              GenericDelegate<Employee<T>>  */
        void ConcreteHandler(Employee<int> sender)
        {
            MessageBox.Show(sender.ToString());
        }

        /* generic delegates and events */
        private void button8_Click(object sender, EventArgs e)
        {
            Employee<string> em = new Employee<string>("sales");            
            em.DepartmentChanged += new GenericDelegate<Employee<string>>(GenericHandler);  // this is really ugly
  
            em.Department = "IT";

            Employee<int> em2 = new Employee<int>(100); 
            em2.DepartmentChanged += ConcreteHandler;   // this is better

            em2.Department = 101;
        }

 
        int globalTotal = 0;

        /* to be used with delegates of type
           delegate void Action<T>(T obj)  */
        void TotalHandler(int obj)
        {
            globalTotal += obj;
        }


        /* using generic methods of the List<T> */
        private void button9_Click(object sender, EventArgs e)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            list.ForEach(TotalHandler);                     // using a generic delegate handler
            MessageBox.Show(globalTotal.ToString());

            int localTotal = 0;
            list.ForEach(delegate(int z)                    // using an anonymous method
            {
                localTotal += z;
            });


            Action<int> action = x => localTotal += x;      // define a lambda expression variable

            list.ForEach(action);                           // using a lambda expression variable
            list.ForEach(x => localTotal += x);             // using a lambda expression directly
            MessageBox.Show(localTotal.ToString());            
        }

        void Display(IList list)
        {
            string S = "";

            foreach (object o in list)
                S += o.ToString() + Environment.NewLine;

            MessageBox.Show(S);
        }


        /* using one of the helper generic interfaces, the IComparer<T> 
           StringComparer is a custom class which implements the  IComparer<T>  */
        private void button10_Click(object sender, EventArgs e)
        {
            string[] cities = { "Rome", "Berlin", "Athens", "Madrid", "London", "Paris", "Oslo"};

            Display(cities);    // a zero bounded array is an IList

            IComparer<string> comparer = new StringComparer();

            Array.Sort<string>(cities, comparer);

            Display(cities);
        }

           


    }
}














namespace Lessons
{
    /* a generic interface */
    public interface IGenericList<T>
    {
        int Add(T Item);
        void Insert(int Index, T Item);
        void Remove(T Item);
        void RemoveAt(int Index);

        int Count { get;}
        T this[int Index] { get; }    
    }


    /* a generic class which implements a generic interface */
    public class GenericList<T> : IGenericList<T>
    {
        private ArrayList list = new ArrayList();

        public int Add(T Item)
        {
            Insert(list.Count, Item);
            return list.Count;
        }

        public virtual void Insert(int Index, T Item)
        {
            list.Insert(Index, Item);
        }

        public virtual void Remove(T Item)
        {
            list.Remove(Item);
        }

        public void RemoveAt(int Index)
        {
            Remove((T)list[Index]);         // type-casting using a type parameter
        }

        public int Count
        {
            get { return list.Count; }
        }

        public T this[int Index]            // generic property
        {
            get { return (T)list[Index]; }  // type-casting using a type parameter
        }
    
    }



    /*  Generics are not covariant 
        Generics are invariant
     
        A generic with a derived type argument can not be assigned 
        to a generic with a base type argument*/
    class Base { }
    class Derived : Base { }
    class Generic<T>
    {
        public static void M()
        {
            Base b = new Derived();

            //Generic<Base> b2 = new Generic<Derived>();    // this does not compile
        }

    }



    /* inheritance and generic classes */
    public class DerivedList<T> : GenericList<T>
    {
        private int insertions = 0;
        private int deletions = 0;

        public override void Insert(int Index, T Item)
        {
            base.Insert(Index, Item);
            insertions++;
        }

        public override void Remove(T Item)
        {
            base.Remove(Item);
            deletions++;
        }
    }


    /* creating a strongly-typed class by just using a generic ancestor class 
       A derived class may decrease the number of type parameters */
    public class IntegerList : GenericList<int>
    {
    }


    /* A derived class may increase the number of type parameters  */
    public class DoubleGenericList<T, T2> : GenericList<T>
    {
    }


    /* constraints on generic type parameters
       using multiple constraints and multiple type parameters */
    public class SomeClass<A, B>
        where A : IList, new()
        where B : IEnumerable
    {
    }


    /* constraints on generic type parameters and inheritance */
    public class GenericValueList<T> : GenericList<T> where T : struct
    {
    }


    /* constraints on generic type parameters 
       The Sorter class constraints its single type parameter to be a IComparable
       Observe the return type of the Sort() method, it's a generic array */
    public class Sorter<T> where T : IComparable
    {
        public T[] Sort(GenericList<T> SourceList)
        {
            T[] elements = new T[SourceList.Count];

            for (int i = 0; i < elements.Length; i++)
                elements[i] = SourceList[i];

            Array.Sort(elements);

            return elements;
        }
    }


    /* a generic delegate */
    public delegate void GenericDelegate<T>(T sender);


    /* a class that uses a generic delegate to define an event */
    public class Employee<T>
    {

        private T department = default(T);  // provides the default value for the actual type

        public Employee(T Department)
        {
            department = Department;
        }

        public override string ToString()
        {
            return "Employee department: " + department.ToString();
        }

        public T Department
        {
            get { return department; }
            set
            {
                if (!department.Equals(value))
                {
                    department = value;
                    if (DepartmentChanged != null)
                        DepartmentChanged(this);
                }
            }
        }

        /* a type argument may be another generic type */
        public event GenericDelegate<Employee<T>> DepartmentChanged;
    }



    /*  a class that implements one of the predefined generic interfaces, the IComparer<T> */
    class StringComparer : IComparer<string>
    {

        /* Comparison methods return table             
                A < B      -1
                A == B      0
                A > B       1                */
        public int Compare(string A, string B)
        {
            if ((A == null) && (B == null))
                return 0;                       // if both are null then return equal
            else if (A == null)
                return -1;
            else if (B == null)
                return 1;
            else                                // both not null
                return A.CompareTo(B);          // so, perform string comparison
        }

    }

}