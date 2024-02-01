using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPS.Encapsulation
{
    public class Bank
    {

        private int _balance;

        public int Balance 
        { get
            {
                return this._balance;
            }
            set
            {
                if(value < 0)
                {
                    throw new Exception("amount cannot be less than 0");
                }
                else
                {
                    this._balance = value;
                }
            } }


        public int Deposit(int amount)
        {
            Balance = Balance + amount;
            return Balance;
        }


        public int Withdraw(int amount)
        {
            if(amount < 0)
            {
                throw new Exception("withdraw not possible");
            }

            if(amount < Balance)
            {
                Balance = Balance - amount;
            }

            return Balance;

        }










    }
}
