using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lessons
{
    public partial class PartialClass
    {
        public PartialClass(int X)
        {
            this.x = X;
        }

        partial void PartialMethod()
        {
            x++;
        }

        public int X
        {
            get { return x; }
        }
    }
}
