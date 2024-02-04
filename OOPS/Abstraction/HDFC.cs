using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    public class HDFC : Bank
    {
        public override void CheckBalance()
        {
            
        }

        public override void Deposit()
        {
            throw new NotImplementedException();
        }

        public override void Withdraw()
        {
            throw new NotImplementedException();
        }


        public override void Welcome()
        {
            Console.WriteLine("Welcome to HDFC Bank");
        }
    }
}
