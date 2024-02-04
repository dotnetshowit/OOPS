using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    public class Square : Shape
    {
        int length = 4;
        public override float GetArea()
        {
            return length * length;
        }
    }
}
