namespace DEVinBank
{
    public class Conta
    {
        public string Nome { get; private set; }
        private string CPF { get; set; }
        public string Endereço { get; private set; }
        public decimal RendaMensal { get; private set; }
        public int NumeroConta { get; private set; }
        public static int Contador = 0;
        public string Agencia { get; private set; }
        public decimal Saldo { get; private set; }

        public Conta(string nome, string cPF, string endereço, decimal rendaMensal, string agencia)
        {
            Nome = nome;
            CPF = ValidaCpf(cPF);
            Endereço = endereço;
            RendaMensal = rendaMensal;
            NumeroConta = Contador;
            Agencia = agencia;
            Contador++;
        }

        public void Saque() { }

        public void Deposito() { }

        public void GetSaldo() { }

        public void Extrato() { }

        public void AlterarDadosCadastrais() { }

        public void Transferencia() { }

        public string ValidaCpf(string cPF)
        {
            CPFCNPJ.IMain testaCpf = new CPFCNPJ.Main();
            if (testaCpf.IsValidCPFCNPJ(cPF) == true) return cPF;
            else throw new Exception("CPF inválido");
        }

    }
}