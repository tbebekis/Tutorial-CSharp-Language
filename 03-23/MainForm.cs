using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


/* Pointers */
namespace Lessons
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
 
        }

        /* declaring pointers
           using the address of operator & 
           accessing the content of a the address a pointer points to */
        private void button1_Click(object sender, EventArgs e)
        {
            unsafe
            {
                int i = 1234;

                int* P = null;                  // declare a pointer to an integer
                P = &i;                         // assign P the address of i, using the address of operator &

                int x = *P;                     // get the data value the P points to, using the indication operator *
                MessageBox.Show(x.ToString());  // it is the initial value of i

                *P = 4567;                      // assign the value 4567 as the content of the address P points to            
                MessageBox.Show(i.ToString());  // suddenly i has a new value
            }
            
        }


        /* pointers and the null literal value 
           getting and displaying the address a pointer points to as an integer
           converting an integer value back to a pointer address */
        private void button2_Click(object sender, EventArgs e)
        {
            unsafe
            {
                int* P = null;                  // P points to the "null address", that is zero

                int x = (int)P;                 // get the address P points to, as an integer
                MessageBox.Show(x.ToString());

                P = &x;                         // assign P the address of x

                x = (int)P;                     // get the address P points to, as an integer
                MessageBox.Show(x.ToString());

                int* P2 = (int*)x;              // convert an integer back to a pointer

                MessageBox.Show((*P2).ToString());
            }
        }

        /* declaring multiple pointer types
           assigning a pointer to a pointer */
        private void button3_Click(object sender, EventArgs e)
        {
            unsafe
            {
                int* P1, P2;
                int x = 123;

                P1 = &x;
                MessageBox.Show(((int)P1).ToString());

                P2 = P1;                            // assign a pointer to another
                MessageBox.Show(((int)P1).ToString());
            }

        }

        /* using the keyword fixed to create fixed size buffers
           fixed size buffers are treated as pointer types */
        private void button4_Click(object sender, EventArgs e)
        {
            unsafe
            {
                Item item = new Item();

                item.Price = 19.90;
                UnsafeUtls.StrToBuf("Hard disk", item.Name, 48);


                string S = UnsafeUtls.BufToStr(item.Name, 48);
                MessageBox.Show(S);
            }
        }

        /* using the keyword fixed to "pin" a managed object variable in order to prevent garbage collection while in the fixed block 
           getting the address of a class field and assigning a pointer 
           pointers pointing to fixed variables can not be changed */
        private void button5_Click(object sender, EventArgs e)
        {
            Coords c = new Coords(10, 20);      // Coords is class, a class instance is subject to garbage collection

            unsafe
            {
                fixed (ulong* pX = &c.x, pY = &c.y)
                {
                    *pX = 100;
                    *pY = 200;

                    //pX++;                     // Error:	Cannot assign to 'pX' because it is a 'fixed variable'	
                }
            }

            MessageBox.Show(c.ToString());
        }

        /* using the keyword stackalloc to allocate a block of memory on the stack
           stackalloc variables are not subject to garbage collection, no pinning with fixed is required */
        private void button6_Click(object sender, EventArgs e)
        {

            unsafe
            {
                const int BufSize = 92;

                char* Buf = stackalloc char[BufSize];
                UnsafeUtls.ClearBuf(Buf, BufSize);

                UnsafeUtls.StrToBuf("C# is a great language", Buf, BufSize);

                string S = UnsafeUtls.BufToStr(Buf, BufSize);
                MessageBox.Show(S);
            }
        }

        /* using stackalloc with unsafe structs to create a pointer to an array of structs
           using the operator -> in accessing members of a pointer variable
           pointer arithmetic using the ++ and -- operators
           PointerArrayVariable[n] is equivalent to the expression (*(PointerArrayVariable + n)) 
           they both de-reference the pointer, that is they return the content of the address the pointer points to*/
        private void button7_Click(object sender, EventArgs e)
        {
            unsafe
            {
                Item* pItems = stackalloc Item[2];                  // allocate two Item elements in the stack

                pItems->Price = 19.90;                              // accessing a member of a struct through a pointer
                UnsafeUtls.StrToBuf("Hard disk", pItems->Name, 48);

                pItems++;                                           // make pItems to point to the second element

                pItems->Price = 5.90;
                UnsafeUtls.StrToBuf("Mouse", pItems->Name, 48);     

                pItems--;                                           // decrease pItems by an element

                string S = UnsafeUtls.BufToStr(pItems->Name, 48);
                MessageBox.Show("Item: " + S + ", Price: " + pItems->Price.ToString());


                S = UnsafeUtls.BufToStr(pItems[1].Name, 48);                                    // P[n] accesses a pointer like an array
                MessageBox.Show("Item: " + S + ", Price: " + (*(pItems + 1)).Price.ToString()); // P[n]  is equivalent to the expression (*(P + n)) 
            }
        }

        /* Memory location content may accessed by indexing a pointer variable just like an array */
        private void button8_Click(object sender, EventArgs e)
        {
            unsafe
            {
                int* P = stackalloc int[2];
                P[0] = 1234;                        // assign an int value as the content to the location P[0] points to
                P[1] = 5678;                        // assign an int value as the content to the location P[1] points to

                int* P2 = P;
                int x = (int)P2;                    // get the address of P[0]
                MessageBox.Show(x.ToString());      // display the address
                MessageBox.Show(P2[0].ToString());  // display the content

                P2++;                               // increment the pointer
                x = (int)P2;                        // get the address of P[1]
                MessageBox.Show(x.ToString());      // display the address
                MessageBox.Show(P2[0].ToString());  // display the content
            }

            
        }
    }
}






namespace Lessons
{
    unsafe public class  UnsafeClass
    {
        static public void Process(int* x)
        {
        }
    }

    public class SafeClass
    {
        unsafe static public void Process(int* x)
        {
        }
    }

    unsafe public struct Item
    {
        public fixed char Name[48];     // this actually becomes a char* pointer
        public double Price;
    }

    public class Coords
    {
        public ulong x;
        public ulong y;

        public Coords(ulong x, ulong y)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return "x = " + x.ToString() + ", y = " + y.ToString();
        }
    }

    unsafe static public class UnsafeUtls
    {
        /* Copies Source to Buf. */
        static public void StrToBuf(string Source, char* Buf, int BufLen)
        {
            int i = 0;

            while ((i < Source.Length) && (i < BufLen))
            {
                Buf[i] = Source[i];         // alternatively   *(Buf + i) = Source[i];
                i++;
            }
        }

        /* Copies Buf to a string. Returns the string */
        static public string BufToStr(char* Buf, int BufLen)
        {
            StringBuilder SB = new StringBuilder();

            for (int i = 0; i < BufLen; i++)
            {
                if (Buf[i] == '\0')         // alternatively  if (*(Buf + i) == '\0')
                    break;
                SB.Append(Buf[i]);          // alternatively  SB.Append(*(Buf + i));
            }

            return SB.ToString();
        }

        /* Puts null characters to Buf */
        static public void ClearBuf(char* Buf, int BufLen)
        {
            for (int i = 0; i < BufLen; i++)
                *(Buf + i) = '\0';
        }
    }





}