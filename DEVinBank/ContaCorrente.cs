using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class ContaCorrente : Conta
    {
        public decimal Limit { get; private set; }
        public ContaCorrente(string nome, string cPF, string endereço, decimal rendaMensal, string agencia) : base(nome, cPF, endereço, rendaMensal, agencia)
        {

        }
    }
}
