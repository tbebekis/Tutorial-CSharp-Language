using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* properties and indexers */
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
            Item item = new Item("Hard disk");
            item.Price = 30.5;

            MessageBox.Show("Name: " + item.Name + ", Price: " + item.Price.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PriceList List = new PriceList();

            List["Monitor"] = 135.75;
            List["Keyboard"] = 8.90;
            List["Mouse"] = 6.50;

            MessageBox.Show(List.Count.ToString());
            MessageBox.Show(List[1].Name);
        }
    }

    
 


    
    /* a simple class with two properties */
    public class Item
    {
        
        protected string name = "";  

        public Item(string Name)
        {
            this.Name = Name;
            Price = 0;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Price { get; set; } // auto-implemented property
    }


    /* a class that represents an item list with an overloaded indexer property */
    public class PriceList
    {
        private ArrayList list = new ArrayList();

        public Item Find(string Name)
        {
            foreach (Item item in list)
                if (item.Name == Name)
                    return item;

            return null;
        }

        public bool Contains(string Name)
        {
            return Find(Name) != null;
        }

        public int Count
        {
            get { return list.Count; }
        }

        public double this[string Name]
        {
            get { return Find(Name).Price; }
            set 
            { 
                Item item = Find(Name);
                if (item == null)
                {
                    item = new Item(Name);
                    list.Add(item);
                }
                item.Price = value;
            }
        }

        public Item this[int Index]
        {
            get 
            { 
                return ((Item)list[Index]); 
            }

        }
    }
 
}
