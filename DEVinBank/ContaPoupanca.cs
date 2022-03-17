using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class ContaPoupanca : Conta
    {
        private readonly decimal RendimentoAoAno= 1.0617M;
        public ContaPoupanca(string nome, string cPF, string endereço, decimal rendaMensal, string agencia) : base(nome, cPF, endereço, rendaMensal, agencia)
        {}
        public decimal SimularPoupanca(decimal valorInvestido, int meses)
        {
            return valorInvestido * RendimentoAoAno * meses;
        }
    }

}
