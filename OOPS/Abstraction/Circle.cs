using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    public class Circle : Shape
    {
        int raduis = 5;
        static float PI = 3.14f;
        public override float GetArea()
        {
            return PI * raduis;
        }
    }
}
