using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class ContaPoupanca : Conta
    {
        private decimal RendimentoAoAno=0;
        public ContaPoupanca(string nome, string cPF, string endereço, decimal rendaMensal, string agencia) : base(nome, cPF, endereço, rendaMensal, agencia)
        {
        }
    }
}
