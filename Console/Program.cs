using DEVinBank;

List<Conta> listaContas = new ();
List<Extrato> listaExtrato = new ();

bool showMenu = true;
            
            while (showMenu)
            {
                 showMenu = MainMenu();
            }
       
          bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Abrir uma conta");
            Console.WriteLine("2) Acessar Conta Corrente");
            Console.WriteLine("3) Acessar Conta poupança");  
            Console.WriteLine("4) Acessar Conta investimento");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                     AbrirContaMenu();
                     return true;
                case "2":
                    AcessarContaMenu("Conta corrente");
                    return true;
                case "3":
                    AcessarContaMenu("Conta poupanca");
                    return true;
                case "4":
                    //AcessarContaInvestimentoMenu();
                    return true;
                case "5":
                    return false;
                default:
                    return true;
            }
        }

      
  

 bool AbrirContaMenu()
{
    Console.Clear();
    Console.WriteLine("Tipo de Conta:");
    Console.WriteLine("1) Conta Corrente");
    Console.WriteLine("2) Conta Poupanca");
    Console.WriteLine("3) Conta Investimento");
    Console.WriteLine("4) Voltar");
    Console.Write("\r\nSelect an option: ");
    switch (Console.ReadLine())
    {
        case "1":
            AbrirContaCadastro("Conta corrente");
            return true;
        case "2":
            AbrirContaCadastro("Conta poupanca");
            return true;
        case "3":
            //AbrirContaIvestimentoMenu(); ;
            return true;
        case "4":
            return false;
        default:
            return true;
    }
}
     bool AbrirContaCadastro(string info)
    {
    double rendaMensal = 0;
       
        Console.Write("Type your name, and then press Enter: ");
        string nome = Console.ReadLine();
        while (nome is null)
        {
            Console.Write("This is not valid input. Please enter an string value: ");
            nome = Console.ReadLine();
        }

        string cPF = PedirCpf();

        Console.Write("Type your endereco, and then press Enter: ");
        string endereco = Console.ReadLine();
        while (endereco is null)
        {
            Console.Write("This is not valid input. Please enter an string value: ");
            endereco = Console.ReadLine();
        }

        Console.Write("Type your renda mensal, and then press Enter: ");
        string tryRendaMensal = Console.ReadLine();
        while (!double.TryParse(tryRendaMensal, out rendaMensal))
        {
            Console.Write("This is not valid input. Please enter an integer value: ");
            tryRendaMensal = Console.ReadLine();
        }


        Console.WriteLine("Agencia:");
        Console.WriteLine("1) 001 - Florianópolis");
        Console.WriteLine("2) 002 - São José");
        Console.WriteLine("3) 003 - Biguaçu");
        Console.WriteLine("4) Voltar ao menu Inicial");
        Console.Write("\r\nSelect an option: ");
        switch (Console.ReadLine())
        {
            case "1":
            switch (info)
            {
                case "Conta corrente":
                    ContaCorrente contaCorrente = new (nome, cPF, endereco, rendaMensal, "001 - Florianópolis");
                    listaContas.Add(contaCorrente);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaCorrente.NumeroConta} para acessa-la posteiormente");
                    Console.ReadLine();
                    return true;
                case "Conta poupanca":
                    ContaPoupanca contaPoupanca = new (nome, cPF, endereco, rendaMensal, "001 - Florianópolis");
                    listaContas.Add(contaPoupanca);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaPoupanca.NumeroConta} para acessa-la posteriormente");
                    Console.ReadLine();
                    return true;
            }
            return true;
        case "2":
                ContaCorrente conta2 = new (nome, cPF, endereco, rendaMensal, "002 - São José");
                listaContas.Add(conta2);
                return true;
            case "3":
                ContaCorrente conta3 = new (nome, cPF, endereco, rendaMensal, "003 - Biguaçu");
                listaContas.Add(conta3);
                return true;
            case "4":
                return false;
            default:
                return true;
        }
    }


 bool AcessarContaMenu(string tipo)
{
    int id = PedirId();
    if (id == 0)
    {
        Console.WriteLine("Conta inexistente aperte qualquer tecla para voltar ao menu inicial");
        Console.ReadLine();
        MainMenu();
    }

    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1) Depositar");
    Console.WriteLine("2) Sacar");
    Console.WriteLine("3) Extrato");
    Console.WriteLine("4) Saldo");
    if(tipo == "Conta poupanca") { Console.WriteLine("10) Simular"); }
    Console.WriteLine("5) Voltar ao menu Inicial");
    Console.Write("\r\nSelect an option: ");
    
    switch (Console.ReadLine())
    {
        case "1":
            Depositar(id);
            return true;
        case "2":
            Sacar(id);
            return true;
        case "3":
            Extrato(id);
            return true;
        case "10":
            VerSimulacao(id);
            return true;
        case "4":
            VerSaldo(id);
            return true;
        case "5":
            return false;
        default:
            return true;
    }
}
string PedirCpf()
{
    string tryCpf = "";
    Console.Write("Type your CPF, and then press Enter: ");
    tryCpf = Console.ReadLine();
    CPFCNPJ.IMain testaCpf = new CPFCNPJ.Main();
    while (testaCpf.IsValidCPFCNPJ(tryCpf) == false)
    {
        Console.Write("CPF invalido! repita seu CPF: ");
        tryCpf = Console.ReadLine();
    }
    return tryCpf;
}
int PedirId()
{
    int id = 0;
    Console.Write("Digite o numero da sua conta e aperte Enter: ");
    string tryId = Console.ReadLine();
    
    while (!int.TryParse(tryId, out id))
    {
        Console.Write("Numero da conta não encontrado! repita seu Numero da conta: ");
        tryId = Console.ReadLine();
    }
    foreach (var item in listaContas)
    {
        if (item.NumeroConta == id)
        {
            return id;
        }
    }
    return id;
}

void Depositar(int id)
{
    double valorDeposito = 0;
    Console.Write("Digite o valor a ser depositado: ");
    string tryValorDeposito = Console.ReadLine();
    while (!double.TryParse(tryValorDeposito, out valorDeposito))
    {
        Console.Write("This is not valid input. Please enter an integer value: ");
        tryValorDeposito = Console.ReadLine();
    }
    foreach (var item in listaContas)
    {
        if (item.NumeroConta == id)
        {
            item.Deposito(valorDeposito);
            Extrato extrato = new Extrato(valorDeposito, item, "Deposito");
            listaExtrato.Add(extrato);
        }
        Console.WriteLine("Deposito realizado!");
        Console.WriteLine($"O valor de {item.Saldo} foi depositado");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
        Console.ReadLine();
        MainMenu();
    }
    
}

void Sacar(int id)
{
    double valorSaque = 0;
    Console.Write("Digite o valor a ser retirado: ");
    string tryValorSaque = Console.ReadLine();
    while (!double.TryParse(tryValorSaque, out valorSaque))
    {
        Console.Write("This is not valid input. Please enter an integer value: ");
        tryValorSaque = Console.ReadLine();
    }
    foreach (var item in listaContas)
    {
        if (item.NumeroConta == id)
        {
            try { item.Saque(valorSaque);
                    Extrato extrato = new Extrato(valorSaque, item, "Saque");
                    listaExtrato.Add(extrato);
            }
            catch (Exception)
            {
                Console.WriteLine("Saldo insuficiente"); 
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                Console.ReadLine();
                MainMenu();

            }
            Console.WriteLine("Saque realizado!");
            Console.WriteLine($"O saldo atual é: {item.Saldo}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            MainMenu();
        }
    }
}

void Extrato(int id)
{
    foreach (var item in listaExtrato)
    {
        if (item.ContaOrigem.NumeroConta == id)
        {
            Console.WriteLine($"A conta:  {item.ContaOrigem.NumeroConta} fez a movimentacao:  {item.Tipo}  de valor:  {item.Valor} no dia:  {item.Date}");
        }
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
        Console.ReadLine();
        MainMenu();
    }
}

void VerSimulacao(int id)
{
    double valorInvestido = 0;
    Console.Write("Digite o valor a ser Investido: ");
    string tryValorInvestido = Console.ReadLine();
    while (!double.TryParse(tryValorInvestido, out valorInvestido))
    {
        Console.Write("This is not valid input. Please enter an integer value: ");
        tryValorInvestido = Console.ReadLine();
    }
    double meses = 0;
    Console.Write("Digite o tempo de rendimento: ");
    string tryMeses = Console.ReadLine();
    while (!double.TryParse(tryMeses, out meses))
    {
        Console.Write("This is not valid input. Please enter an integer value: ");
        tryMeses = Console.ReadLine();
    }
    double result = ContaPoupanca.SimularPoupanca(valorInvestido, meses);
    Console.WriteLine("Simulação realizada!");
    Console.WriteLine($"O retorno da poupanca será de: {result}");
    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
    Console.ReadLine();
    MainMenu();
}

    void VerSaldo(int id)
{
    
    foreach (var item in listaContas)
    {
        if (item.NumeroConta == id)
        {
            Console.WriteLine($"O saldo atual é: {item.Saldo}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            MainMenu();
        }
    }
}