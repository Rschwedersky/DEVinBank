using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class ContaInvestimento : Conta
    {
        public ContaInvestimento(string nome, string cPF, string endereço, double rendaMensal, string agencia) : base(nome, cPF, endereço, rendaMensal, agencia)
        {
        }
    }
}
