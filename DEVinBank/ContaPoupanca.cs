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
            double parcial = valorInvestido * (Math.Pow((1.0 + RendimentoAoMes), meses));
            return (parcial);
        }
        public override void Deposito(double value)
        {
            base.Deposito(value);
            DataRendimento = DateTime.Now;
        }

        //public override decimal GetSaldo()
        //{
        //    DateTime timeNow =DateTime.Now;
        //    var dateSpan = DateTimeSpan.CompareDates(compareTo, now);
        //   if ()
        //  return Saldo;
        //}

    }
}
