using DEVinBank;

List<Conta> listaContas = new List<Conta>();
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
            Console.WriteLine("2) Conta Corrente");
            Console.WriteLine("3) Conta poupança");  
            Console.WriteLine("4) Conta investimento");
            Console.WriteLine("5) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                 AbrirContaMenu();
                 return true;
                case "2":
                    AcessarContaCorrenteMenu();
                    return true;
                case "3":
                    //AcessarContaPoupancaMenu();
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
            AbrirContaCorrenteMenu();
            return true;
        case "2":
            //AbrirContaPoupancaMenu();
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
     bool AbrirContaCorrenteMenu()
    {
    string nome = "";
        string cPF = "";
        string endereco = "";
        string tryRendaMensal = "";
        decimal rendaMensal = 0;
        

        Console.Write("Type your name, and then press Enter: ");
        nome = Console.ReadLine();

        cPF = PedirCpf();

        Console.Write("Type your endereco, and then press Enter: ");
        endereco = Console.ReadLine();

        Console.Write("Type your renda mensal, and then press Enter: ");
        tryRendaMensal = Console.ReadLine();
        while (!decimal.TryParse(tryRendaMensal, out rendaMensal))
        {
            Console.Write("This is not valid input. Please enter an integer value: ");
            tryRendaMensal = Console.ReadLine();
        }


        Console.WriteLine("Agencia:");
        Console.WriteLine("1) 001 - Florianópolis");
        Console.WriteLine("2) 002 - São José");
        Console.WriteLine("3) 003 - Biguaçu");
        Console.WriteLine("4) Voltar");
        Console.Write("\r\nSelect an option: ");
        switch (Console.ReadLine())
        {
            case "1":
                ContaCorrente conta = new ContaCorrente(nome, cPF, endereco, rendaMensal, "001 - Florianópolis");
                listaContas.Add(conta);
            Conta result = listaContas.Find(item=>item.CPF == cPF);//TODO
            Console.WriteLine(result);
                Console.ReadLine();
            return true;
            case "2":
                ContaCorrente conta2 = new ContaCorrente(nome, cPF, endereco, rendaMensal, "002 - São José");
                listaContas.Add(conta2);
                return true;
            case "3":
                ContaCorrente conta3 = new ContaCorrente(nome, cPF, endereco, rendaMensal, "003 - Biguaçu");
                listaContas.Add(conta3);
                return true;
            case "4":
                return false;
            default:
                return true;
        }
    }


 bool AcessarContaCorrenteMenu()
{
    string cPF = PedirCpf();//TODO
    Conta result = listaContas.Find(item => item.CPF == cPF);

    Console.WriteLine("Choose an option:");
    Console.WriteLine("1) Depositar");
    Console.WriteLine("2) --");
    Console.WriteLine("2) --");
    Console.WriteLine("2) --");
    Console.WriteLine("3) Exit");
    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            Depositar();
            Console.WriteLine($"O valor de {result.Saldo} foi depositado");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            return true;
        case "2":
            
            return true;
        case "3":
            
            return true;
        case "4":
            
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
void Depositar()
{
    string cPF = PedirCpf();
    decimal valorDeposito = 0;
    string tryValorDeposito = "";
    Console.Write("Digite o valor a ser depositado: ");
    tryValorDeposito = Console.ReadLine();
    while (!decimal.TryParse(tryValorDeposito, out valorDeposito))
    {
        Console.Write("This is not valid input. Please enter an integer value: ");
        tryValorDeposito = Console.ReadLine();
    }
    foreach (var item in listaContas)
    {
        if (item.CPF == cPF)
        {
            item.Deposito(valorDeposito);
        }
    }
}