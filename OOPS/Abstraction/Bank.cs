using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Abstraction
{
    public abstract class Bank
    {
        public abstract void Deposit();

        public abstract void Withdraw();

        public abstract void CheckBalance();

        public virtual void Welcome()
        {
            Console.WriteLine("Welcome to the Bank");
        }
    }
}
