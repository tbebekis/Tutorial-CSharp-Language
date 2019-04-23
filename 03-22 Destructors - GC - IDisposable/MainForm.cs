using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;




/* Destructors and the Garbage Collector - IDisposable  */
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
            Disposable d = new Disposable();
            try
            {
                // code here
            }
            finally
            {
                d.Dispose();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (StreamReader SR = new StreamReader("C:\\Windows\\ODBC.INI")) // StreamReader is IDisposable
            {
                string S = SR.ReadLine();
                if (!string.IsNullOrEmpty(S))
                    MessageBox.Show(S);
            } 
        }
    }
}


namespace Lessons
{
    public class Disposable: IDisposable
    {
        private bool disposed = false;    // true if the protected Dispose() is called

        /* The disposing parameter is true when this method is called
           by the public Dispose() method, that is by application code.
           The disposing parameter is false when this method is called 
           by the destructor, that is by the GC.   */
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    // dispose managed resources here 
                }

                // dispose unmanaged resources here

                disposed = true;
            }            
        }

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);  // instructs GC not bother to call the destructor
        }
 
    }
}




namespace Suggestion
{
    public class Disposable : IDisposable
    {
        private bool disposed = false;     

 
        private void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                    DisposeManagedResources();

                DisposeUnmanagedResources();

                disposed = true;
            }
        }

        protected virtual void DisposeManagedResources()
        {
        }

        protected virtual void DisposeUnmanagedResources()
        {
        }

        ~Disposable()
        {
            Dispose(false);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);   
        }

        public bool IsDisposed
        {
            get { return disposed; }
        }

    }
}