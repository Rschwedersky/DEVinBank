using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class ContaCorrente : Conta
    {
        public decimal Limit = 0.1M;
        public ContaCorrente(string nome, string cPF, string endereço, decimal rendaMensal, string agencia) : base(nome, cPF, endereço, rendaMensal, agencia)
        {

        }
        public override void Saque(decimal value)
        {
            if (Saldo + Limit*RendaMensal < value)
            {
                throw new Exception("Balance unavailable.");
            }
            Saldo -= value;
        }
    }
}
