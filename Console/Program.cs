﻿using DEVinBank;

List<Conta> listaContas = new List<Conta>();
List<Extrato> listaExtrato = new List<Extrato>();

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
            string tipo = "Conta corrente";
            AbrirContaCorrenteMenu(tipo);
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
     bool AbrirContaCorrenteMenu(string info)
    {
        string tipo=info;
        string nome = "";
        string cPF = "";
        string endereco = "";
        string tryRendaMensal = "";
        decimal rendaMensal = 0;
        

        Console.Write("Type your name, and then press Enter: ");
        nome = Console.ReadLine();
        while (nome is null)
        {
            Console.Write("This is not valid input. Please enter an string value: ");
            nome = Console.ReadLine();
        }

        cPF = PedirCpf();

        Console.Write("Type your endereco, and then press Enter: ");
        endereco = Console.ReadLine();
        while (endereco is null)
        {
            Console.Write("This is not valid input. Please enter an string value: ");
            endereco = Console.ReadLine();
        }

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
        Console.WriteLine("4) Voltar ao menu Inicial");
        Console.Write("\r\nSelect an option: ");
        switch (Console.ReadLine())
        {
            case "1":
            switch (info)
            {
                case "Conta corrente":
                    ContaCorrente contaCorrente = new ContaCorrente(nome, cPF, endereco, rendaMensal, "001 - Florianópolis");
                    listaContas.Add(contaCorrente);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaCorrente.NumeroConta} para acessa-la posteiormente");
                    Console.ReadLine();
                    return true;
                case "Conta Poupanca":
                    ContaPoupanca contaPoupanca = new ContaPoupanca(nome, cPF, endereco, rendaMensal, "001 - Florianópolis");
                    listaContas.Add(contaPoupanca);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaPoupanca.NumeroConta} para acessa-la posteiormente");
                    Console.ReadLine();
                    return true;
            }
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

    Console.Clear();
    Console.WriteLine("Choose an option:");
    Console.WriteLine("1) Depositar");
    Console.WriteLine("2) Sacar");
    Console.WriteLine("3) Extrato");
    Console.WriteLine("4) Saldo");
    Console.WriteLine("5) Voltar ao menu Inicial");
    Console.Write("\r\nSelect an option: ");

    switch (Console.ReadLine())
    {
        case "1":
            Depositar();
            return true;
        case "2":
            Sacar();
            return true;
        case "3":
            
            return true;
        case "4":
            VerSaldo(); // id como parametro!!!!!!!!
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
            Extrato extrato = new Extrato(valorDeposito, item, "Deposito Conta Corrente");
            listaExtrato.Add(extrato);
        }
        Console.WriteLine("Deposito realizado!");
        Console.WriteLine($"O valor de {item.Saldo} foi depositado");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
        Console.ReadLine();
    }
    
}

void Sacar()
{
    string cPF = PedirCpf();
    decimal valorSaque = 0;
    string tryValorSaque = "";
    Console.Write("Digite o valor a ser retirado: ");
    tryValorSaque = Console.ReadLine();
    while (!decimal.TryParse(tryValorSaque, out valorSaque))
    {
        Console.Write("This is not valid input. Please enter an integer value: ");
        tryValorSaque = Console.ReadLine();
    }
    foreach (var item in listaContas)
    {
        if (item.CPF == cPF)
        {
            try { item.Saque(valorSaque); }
            catch (Exception)
            {
                Console.WriteLine("Saldo insuficiente"); 
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                Console.ReadLine();
                AcessarContaCorrenteMenu();

            }
            Console.WriteLine("Saque realizado!");
            Console.WriteLine($"O saldo atual é: {item.Saldo}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            AcessarContaCorrenteMenu();
        }
    }
}
void VerSaldo()
{
    string cPF = PedirCpf();
   
    foreach (var item in listaContas)
    {
        if (item.CPF == cPF)
        {
            Console.WriteLine($"O saldo atual é: {item.Saldo}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            AcessarContaCorrenteMenu();
        }
    }
}