using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Inheritance
{
    public class Parent
    {
        public Parent()
        {
            Console.WriteLine("Parent Constructor");
        }
        public int ParentProperty { get; set; }

        public virtual void Print()
        {
            Console.WriteLine("From Parent");
        }
    }
}
