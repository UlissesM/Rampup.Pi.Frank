using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampupPI.Bank.Model
{
    public class Account : Object
    {
        public int nAccount { get; set;}
        public ICustomer customer { get; private set; }

        public double balance { get; protected set; }
        public StringBuilder itoken { get; private set; }

        int indexTypeAccount;

        public Account(int nAccount, ICustomer customer,int indexTypeAccount, StringBuilder itoken, double balance = 0)
        {
            //AddCustomer(nAccount, customer, indexTypeAccount, itoken, balance);

        }

        private void AddCustomer(int nAccount, ICustomer customer, int indexTypeAccount, StringBuilder itoken, double balance)
        {
            this.nAccount = nAccount;
            this.customer = customer;
            this.indexTypeAccount = indexTypeAccount;
            this.itoken = itoken;
            this.balance = balance;
        }

        public virtual void Deposit(double value)
        {
            if (value <= 0)
            {
                ValueExption();
            }
            else
            balance += value;
        }

        public virtual void Withdraw( double value)
        {
            if (value <= 0)
            {
                ValueExption();
            }
            else
                balance -= value;
        }

        public string tAccount()
        {
            return Enum.GetName(typeof(TypeAccount), indexTypeAccount);
        }

        public void Transfer(Account aOwner, Account aAnother,double value)
        {
            if (value <= 0)
            {
                ValueExption();
            }
            else
            {
                aOwner.balance -= value;
                aAnother.balance += value;
            }
           
        }

        public void ValueExption()
        {
            throw new Exception();
        }

        public override bool Equals(object obj)
        {
            Account account = (Account)obj; //conversão obj
            return this.itoken.Equals(account.itoken);
        }
       

    }
    public enum TypeAccount
    {
        Corrente = 0,
        Poupança,
    }
}
