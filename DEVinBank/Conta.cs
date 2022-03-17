namespace DEVinBank
{
    public class Conta
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Endereço { get; private set; }
        public decimal RendaMensal { get; private set; }
        public int NumeroConta { get; private set; }
        
        private static int Contador = 0;
        public string Agencia { get; private set; }
        public decimal Saldo { get; private protected set; }
        
        public List<Extrato>? ListaExtrato { get; private set; }

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

        public virtual void Saque(decimal value) {
            if (Saldo < value)
            {
                throw new Exception("Balance unavailable.");
            }

            Saldo -= value;
        }

        public virtual void Deposito(decimal value) {
            
            this.Saldo += value;
            

        }

        public decimal GetSaldo() {
            return Saldo;
        }


        public void AlterarDadosCadastrais() { }

        public void Transferencia() { }

        public void SalvaContas() { }

        public string ValidaCpf(string cPF)
        {
            CPFCNPJ.IMain testaCpf = new CPFCNPJ.Main();
            if (testaCpf.IsValidCPFCNPJ(cPF) == true) return cPF;
            else throw new Exception("CPF inválido");
        }

    }
}