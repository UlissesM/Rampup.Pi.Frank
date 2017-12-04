using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampupPI.Bank.Model
{
    public class CurrentAccount : Account
    {
        public CurrentAccount(int nAccount, ICustomer customer,int indexTypeAccount,StringBuilder itoken, double balance = 0) : base(nAccount, customer, indexTypeAccount, itoken,balance)
        {
        }

        public override void Withdraw(double value)
        {
            base.Withdraw(value);
        }

    }
}
