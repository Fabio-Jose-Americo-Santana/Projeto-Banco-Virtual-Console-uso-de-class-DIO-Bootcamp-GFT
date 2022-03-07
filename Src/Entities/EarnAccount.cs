using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Banco__uso_de_class__DIO_Bootcamp_GFT.Src.Entities
{
    internal class EarnAccount : Account
    {
        public EarnAccount(Customer customer) : base(customer)
        {

        }

        public decimal Yield { get; private set; }

        public decimal GetYield()
        {
            return Balance * Convert.ToDecimal(0.05);
        }

        public override decimal GetBalance()
        {
            return Balance + GetYield();
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
