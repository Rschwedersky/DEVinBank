namespace DEVinBank
{
    public class Conta
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Endereço { get; set; }
        public decimal RendaMensal { get; set; }
        public int NumeroConta { get; set; }
        public int Agencia { get; set; }
        public decimal Saldo { get; set; }

        public void Saque() { }

        public void Deposito() { }

        public void GetSaldo() { }

        public void Extrato() { }

        public void AlterarDadosCadastrais() { }

        public void Transferencia() { }

    }
}