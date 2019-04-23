using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lessons
{
    public partial class PartialClass
    {
        private int x;

        public PartialClass()
        {
        }

        partial void PartialMethod();
    }

}
