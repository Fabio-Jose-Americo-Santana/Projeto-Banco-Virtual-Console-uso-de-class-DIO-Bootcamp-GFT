using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco__uso_de_class__DIO_Bootcamp_GFT.Src.Entities
{
    internal class CurrentAccount: Account
    {
        public CurrentAccount(Customer cliente) : base(cliente)
        {
        }

        public override decimal GetBalance()
        {
            return Balance;
        }

        public override bool Deposit(decimal value)
        {
            Balance += value;
            return true;
        }

        public override string GetMoney(decimal value)
        {
            if (value > Balance)
                return "Saldo Insuficiente";

            Balance -= value;

            return $"Valor Sacado é :{value}";
        }
    }
}
