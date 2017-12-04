using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RampupPI.Bank.Model
{
    public class Customer : ICustomer
    {
        private string name;
        private string cpf;

        public Customer(string name, string cpf)
        {
            this.name = name;
            this.cpf = cpf;
        }

        public string getName()
        {
            return name;
        }

        public string getCpf()
        {
            return cpf;
        }

    }
}
