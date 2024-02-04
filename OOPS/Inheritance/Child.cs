using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Inheritance
{
    public class Child : Parent
    {
        public Child()
        {
            Console.WriteLine("Child Constructor");
        }
        public int ChildProperty { get; set; }


        public override void Print()
        {
            Console.WriteLine(x);
        }
    }



}
