using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco__uso_de_class__DIO_Bootcamp_GFT.Src.Entities
{
    internal abstract class Account
    {
        public int ID { get; private set; }
        public decimal Balance { get; set; }
        public int Agency { get; set; }
        public int AccountNumber { get; set; }

        public Account(Customer customer)
        {
            this.ID = Convert.ToInt32(customer.Document.ToString().Substring(0, 3));

            Balance = 100;
            Agency = 2022;
            AccountNumber = Convert.ToInt32(customer.Document.ToString().Substring(0, 5));
        }

        public abstract decimal GetBalance();
        public abstract bool Deposit(decimal value);
        public abstract string GetMoney(decimal value);
    }
}