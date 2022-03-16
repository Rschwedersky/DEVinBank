﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DEVinBank
{
    public class Extrato
    {
       public Conta? ContaDestino { get; private set; }
       public decimal Valor { get; private set; }
       public DateTime Date { get; private set; }

        public Extrato( Conta contaDestino, decimal valor)
        {
            ContaDestino = contaDestino;
            Valor = valor;
            Date = DateTime.Now;
        }
        public Extrato(decimal valor)
        {
            Valor = valor;
            Date = DateTime.Now;
        }
    }
}
