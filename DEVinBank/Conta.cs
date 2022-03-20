namespace DEVinBank
{
    public class Conta
    {
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public string Endereço { get; private set; }
        public double RendaMensal { get; private set; }
        public int NumeroConta { get; private set; }
        
        private static int Contador = 1;
        public string Agencia { get; private set; }
        public double Saldo { get; private protected set; }

        public List<Extrato>? ListaExtrato = new(); 

        public Conta(string nome, string cPF, string endereço, double rendaMensal, string agencia)
        {
            Nome = nome;
            CPF = cPF;
            Endereço = endereço;
            RendaMensal = rendaMensal;
            NumeroConta = Contador;
            Agencia = agencia;
            Contador++;
           
        }
        public virtual void Extrato(Extrato extrato)
        {
            ListaExtrato.Add(extrato);
        }
        public virtual void Saque(double value) {
            if (Saldo < value)
            {
                throw new Exception("Saldo insuficiente para a operação.");
            }

            Saldo -= value;
        }

        public virtual void Deposito(double value) {
            
            this.Saldo += value;
            

        }

        public virtual double GetSaldo() {
            return Saldo;
        }

        
        public void AlterarDadosCadastrais(string nome, string endereço, double rendaMensal, string agencia) {
            Nome = nome;
            Endereço = endereço;
            RendaMensal = rendaMensal;
            Agencia = agencia;
        }

        public virtual void Transferencia(double valor, Conta entrada) 
        {
            string dia = DateTime.Today.DayOfWeek.ToString();
            if ((dia == "Saturday") || (dia == "Sunday"))
            {
                throw new Exception("Transferência não permitida nos Sábados e Domingos.");
            }
            if (CPF==entrada.CPF)
            {
                throw new Exception("Transferência não permitida para contas com o mesmo CPF");
            }
            this.Saque(valor);
            entrada.Deposito(valor);
        }
        public virtual void DepositoInvestimento(double value, string tipoAplicacao)
        { }




        }
}