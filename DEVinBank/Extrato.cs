using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class Extrato
    {
       public Conta? ContaDestino { get; private set; }
        public Conta ContaOrigem { get; private set; }
        public decimal Valor { get; private set; }
      
        public string Tipo { get; private set; }
        public DateTime Date { get; private set; }

        public Extrato(decimal valor, Conta contaOrigem, Conta contaDestino, string tipo)
        {
            ContaOrigem = contaOrigem;
            ContaDestino = contaDestino;
            Valor = valor;
            Tipo = tipo;
            Date = DateTime.Now;
        }
        public Extrato(decimal valor, Conta contaOrigem, string tipo)
        {
            ContaOrigem = contaOrigem;
            Valor = valor;
            Tipo = tipo;
            Date = DateTime.Now;
        }
    }
}
