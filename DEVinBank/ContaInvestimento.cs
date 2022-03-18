using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class ContaInvestimento : Conta
    {
        public double SaldoLCI { get; private set; }
        public double SaldoLCA { get; private set; }
        public double SaldoCDB { get; private set; }

        public ContaInvestimento(string nome, string cPF, string endereço, double rendaMensal, string agencia) : base(nome, cPF, endereço, rendaMensal, agencia)
        {}

        public static double SimularInvestimento(double valorInvestido, double meses,string tipo)
        {
            switch (tipo)
            {
                case "LCI":
                    if (meses>6) return (valorInvestido * (Math.Pow((1.0 + (0.08/12)), meses)));
                    throw new Exception("Meses insuficientes para a aplicação.");
                case "LCA":
                    if (meses > 12) return (valorInvestido * (Math.Pow((1.0 + (0.09 / 12)), meses)));
                    throw new Exception("Meses insuficientes para a aplicação.");
                case "CDB":
                    if (meses > 12) return (valorInvestido * (Math.Pow((1.0 + (0.09 / 12)), meses)));
                    throw new Exception("Meses insuficientes para a aplicação.");
                default:
                    throw new Exception("Algo deu errado.");
            }
        }
        public void LCI() { }
        public void LCA() { }
        public void CDB() { }
    }
}
