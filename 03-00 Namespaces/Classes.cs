using System;


namespace Lessons.Classes                           // defines the nested namespace Classes
{
    using Forms = System.Windows.Forms;             // creating an alias for System.Windows.Forms

    class BaseClass
    {
        public void DisplayFullName()
        {
            Type T = this.GetType();                // Type is a member of System 
            Forms.MessageBox.Show(T.FullName);      // Forms is an alias for System.Windows.Forms
        }
    }
}



// a source document may have many namespace declarations
// and it may redeclare the same namespace in any notation
namespace Lessons
{
    namespace Classes                   // Classes becomes a nested namespace  (if it not already is)
    {
        class SomeClass : BaseClass     // SomeClass inherits from Lessons.Classes.BaseClass 
        { 
        }
    }
}



// A namespace is used in avoiding name clashing and in organizing classes and types.  
namespace namespaceA
{
    class SomeClass : Lessons.Classes.BaseClass     // SomeClass inherits from Lessons.Classes.BaseClass 
    {
    }
}

namespace namespaceB
{
    class SomeClass : Lessons.Classes.BaseClass     // SomeClass inherits from Lessons.Classes.BaseClass 
    {
    }
}