using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class ContaPoupanca : Conta
    {
        public DateTime DataRendimento = DateTime.Now;

        private static double RendimentoAoMes = .0617;
        public ContaPoupanca(string nome, string cPF, string endereço, double rendaMensal, string agencia) : base(nome, cPF, endereço, rendaMensal, agencia)
        { }
        public static double SimularPoupanca(double valorInvestido, double meses)
        {
            return (valorInvestido * (Math.Pow((1.0 + RendimentoAoMes), meses)));
        }
        public override void Deposito(double value)
        {
            base.Deposito(value);
            DataRendimento = DateTime.Now;
        }

        public override double GetSaldo()
        {
            DateTime timeNow =DateTime.Now;
            var dateSpan = DateTimeSpan.CompareDates(DataRendimento, timeNow);
           if (dateSpan.Months>0) Saldo = (Saldo * (Math.Pow((1.0 + RendimentoAoMes), dateSpan.Months)));
          return Saldo;
        }

    }
}
