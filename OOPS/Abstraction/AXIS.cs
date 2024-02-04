using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    public class AXIS : Bank
    {
        public override void CheckBalance()
        {
            throw new NotImplementedException();
        }

        public override void Deposit()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw()
        {
            throw new NotImplementedException();
        }

        //public override void Welcome()
        //{
        //    Console.WriteLine("Welcome to AXIS Bank");
        //}
    }
}
