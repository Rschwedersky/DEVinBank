using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class ContaInvestimento : Conta
    {
        public DateTime DataLCI { get; private set; }
        public DateTime DataLCA { get; private set; }
        public DateTime DataCDB { get; private set; }

        public ContaInvestimento(string nome, string cPF, string endereço, double rendaMensal, string agencia) : base(nome, cPF, endereço, rendaMensal, agencia)
        {
            DataLCI= DateTime.Now;
            DataLCA = DateTime.Now;
            DataCDB = DateTime.Now;
        }

        public static double SimularInvestimento(double valorInvestido, double meses, string tipoAplicacao)
        {
            switch (tipoAplicacao)
            {
                case "LCI":
                    if (meses >= 6) return (valorInvestido * (Math.Pow((1.0 + (0.08 / 12)), meses)));
                    throw new Exception("Meses insuficientes para a aplicação.");
                case "LCA":
                    if (meses >= 12) return (valorInvestido * (Math.Pow((1.0 + (0.09 / 12)), meses)));
                    throw new Exception("Meses insuficientes para a aplicação.");
                case "CDB":
                    if (meses >= 36) return (valorInvestido * (Math.Pow((1.0 + (0.1 / 12)), meses)));
                    throw new Exception("Meses insuficientes para a aplicação.");
                default:
                    throw new Exception("Algo deu errado.");
            }
        }


        public override void DepositoInvestimento(double value, string tipoAplicacao)
        {
            DateTime timeNow = DateTime.Now;

            switch (tipoAplicacao)
            {
                case "LCI":
                    var dateSpan = DateTimeSpan.CompareDates(DataLCI, timeNow);
                    if (dateSpan.Months > 6) { Saldo = (Saldo * (Math.Pow((1.0 + (0.08 / 12)), dateSpan.Months))); }
                    base.Deposito(value);
                    DataLCI = DateTime.Now;
                    break;
                case "LCA":
                    var dateSpan1 = DateTimeSpan.CompareDates(DataLCA, timeNow);
                    if (dateSpan1.Years > 0) { Saldo = (Saldo * (Math.Pow((1.0 + (0.08 / 12)), dateSpan1.Months))); }
                    base.Deposito(value);
                    DataLCA = DateTime.Now;
                    break;
                case "CDB":
                    var dateSpan3 = DateTimeSpan.CompareDates(DataCDB, timeNow);
                    if (((dateSpan3.Years * 12) + dateSpan3.Months) > 36) { Saldo = (Saldo * (Math.Pow((1.0 + (0.08 / 12)), dateSpan3.Months))); }
                    base.Deposito(value);
                    DataCDB = DateTime.Now;
                    break;
                default:
                    throw new Exception("Algo deu errado.");
            }
        }
        public override double GetSaldo()
        {
            DateTime timeNow = DateTime.Now;
            var dateSpan1 = DateTimeSpan.CompareDates(DataLCI, timeNow);
            var dateSpan2 = DateTimeSpan.CompareDates(DataLCA, timeNow);
            var dateSpan3 = DateTimeSpan.CompareDates(DataCDB, timeNow);
            if (dateSpan1.Months >= 6) { Saldo = (Saldo * (Math.Pow((1.0 + (0.08 / 12)), dateSpan1.Months))); }
            if (dateSpan2.Months >= 12) { Saldo = (Saldo * (Math.Pow((1.0 + (0.09 / 12)), dateSpan2.Months))); }
            if (((dateSpan3.Years * 12) + dateSpan3.Months) > 36) { Saldo = (Saldo * (Math.Pow((1.0 + (0.1 / 12)), dateSpan3.Months))); }
            return Saldo;
        }
        public override void Saque(double value)
        {
            DateTime timeNow = DateTime.Now;
            var dateSpan1 = DateTimeSpan.CompareDates(DataLCI, timeNow);
            var dateSpan2 = DateTimeSpan.CompareDates(DataLCA, timeNow);
            var dateSpan3 = DateTimeSpan.CompareDates(DataCDB, timeNow);
            if (dateSpan1.Months >= 6) { Saldo = (Saldo * (Math.Pow((1.0 + (0.08 / 12)), dateSpan1.Months))); }
            if (dateSpan2.Months >= 12) { Saldo = (Saldo * (Math.Pow((1.0 + (0.09 / 12)), dateSpan2.Months))); }
            if (((dateSpan3.Years * 12) + dateSpan3.Months) > 36) { Saldo = (Saldo * (Math.Pow((1.0 + (0.1 / 12)), dateSpan3.Months))); }
            base.Saque(value);
        }
        public override void Transferencia(double valor, Conta entrada)
        {
            DateTime timeNow = DateTime.Now;
            var dateSpan1 = DateTimeSpan.CompareDates(DataLCI, timeNow);
            var dateSpan2 = DateTimeSpan.CompareDates(DataLCA, timeNow);
            var dateSpan3 = DateTimeSpan.CompareDates(DataCDB, timeNow);
            if (dateSpan1.Months >= 6) { Saldo = (Saldo * (Math.Pow((1.0 + (0.08 / 12)), dateSpan1.Months))); }
            if (dateSpan2.Months >= 12) { Saldo = (Saldo * (Math.Pow((1.0 + (0.09 / 12)), dateSpan2.Months))); }
            if (((dateSpan3.Years * 12) + dateSpan3.Months) > 36) { Saldo = (Saldo * (Math.Pow((1.0 + (0.1 / 12)), dateSpan3.Months))); }
            base.Transferencia(valor, entrada);
        }

        //fazer met ddeposito retornar errro
    }
}

       
