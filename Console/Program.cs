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
            Console.WriteLine("2) Acessar Minhas Contas");
            Console.WriteLine("3) Relatórios");
            Console.WriteLine("4) Sair");
            Console.Write("\r\nSelecione uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                     AbrirContaMenu();
                     return true;
                case "2":
                     AcessarContaMenu();
                     return true;
                case "3":
                     AcessarRelatoriosMenu();
                     return true;
                case "4":
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
            AbrirContaCadastro("Conta investimento");
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
       
        Console.Write("Escreva seu nome e aperte Enter: ");
        string nome = Console.ReadLine();
        while (nome =="")
        {
            Console.Write("Escreva seu nome novamente e aperte Enter: ");
            nome = Console.ReadLine();
        }

        string cPF = PedirCpf();

        Console.Write("Escreva seu endereço e aperte Enter: ");
        string endereco = Console.ReadLine();
        while (nome == "")
        {
            Console.Write("Escreva seu endereço novamente e aperte Enter: ");
            endereco = Console.ReadLine();
        }

        Console.Write("Escreva sua renda mensal e aperte Enter: ");
        string tryRendaMensal = Console.ReadLine();
        while (!double.TryParse(tryRendaMensal, out rendaMensal))
        {
            Console.Write("Escreva sua renda mensal novamente e aperte Enter: ");
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
                case "Conta investimento":
                    ContaInvestimento contaInvestimento = new(nome, cPF, endereco, rendaMensal, "001 - Florianópolis");
                    listaContas.Add(contaInvestimento);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaInvestimento.NumeroConta} para acessa-la posteriormente");
                    Console.ReadLine();
                    return true;
                }
                return true;
            case "2":
                switch (info)
                {
                case "Conta corrente":
                    ContaCorrente contaCorrente = new(nome, cPF, endereco, rendaMensal, "002 - São José");
                    listaContas.Add(contaCorrente);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaCorrente.NumeroConta} para acessa-la posteiormente");
                    Console.ReadLine();
                    return true;
                case "Conta poupanca":
                    ContaPoupanca contaPoupanca = new(nome, cPF, endereco, rendaMensal, "002 - São José");
                    listaContas.Add(contaPoupanca);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaPoupanca.NumeroConta} para acessa-la posteriormente");
                    Console.ReadLine();
                    return true;
                case "Conta investimento":
                    ContaInvestimento contaInvestimento = new(nome, cPF, endereco, rendaMensal, "002 - São José");
                    listaContas.Add(contaInvestimento);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaInvestimento.NumeroConta} para acessa-la posteriormente");
                    Console.ReadLine();
                    return true;
                }
                return true;
           case "3":
            switch (info)
            {
                case "Conta corrente":
                    ContaCorrente contaCorrente = new(nome, cPF, endereco, rendaMensal, "003 - Biguaçu");
                    listaContas.Add(contaCorrente);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaCorrente.NumeroConta} para acessa-la posteiormente");
                    Console.ReadLine();
                    return true;
                case "Conta poupanca":
                    ContaPoupanca contaPoupanca = new(nome, cPF, endereco, rendaMensal, "003 - Biguaçu");
                    listaContas.Add(contaPoupanca);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaPoupanca.NumeroConta} para acessa-la posteriormente");
                    Console.ReadLine();
                    return true;
                case "Conta investimento":
                    ContaInvestimento contaInvestimento = new(nome, cPF, endereco, rendaMensal, "003 - Biguaçu");
                    listaContas.Add(contaInvestimento);
                    Console.WriteLine("Conta criada com sucesso!");
                    Console.WriteLine($"Guarde o numero:{contaInvestimento.NumeroConta} para acessa-la posteriormente");
                    Console.ReadLine();
                    return true;
            }
                return true;
            case "4":
                return false;
            default:
                return true;
        }
    }


 bool AcessarContaMenu()
{
    int id = PedirId();
    if (id == 0)
    {
        Console.WriteLine("Conta inexistente aperte qualquer tecla para voltar ao menu inicial");
        Console.ReadLine();
        MainMenu();
    }

   Conta contaTipo = listaContas.Find(i => i.NumeroConta == id);
   string tipo = contaTipo.GetType().Name;
    
  
   

    Console.Clear();
    Console.WriteLine("Choose an option:");
    if ((tipo == "ContaPoupanca") || (tipo == "ContaCorrente")) { Console.WriteLine("1) Depositar"); }
    Console.WriteLine("2) Sacar");
    Console.WriteLine("3) Extrato");
    Console.WriteLine("4) Saldo");
    Console.WriteLine("5) Transferir");
    Console.WriteLine("6) Atualizar cadastro");
    if (tipo == "ContaPoupanca") { Console.WriteLine("10) Simular"); }
    if (tipo == "ContaInvestimento") { Console.WriteLine("10) Simular e Investir"); }
    Console.WriteLine("7) Voltar ao menu Inicial");
    Console.Write("\r\nSelecione uma operação: ");
    
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
            VerSimulacao(id, tipo);
            return true;
        case "4":
            VerSaldo(id);
            return true;
        case "5":
           Transferir(id);
            return true;
        case "6":
            AtualizarCadastro(id);
            return true;
        case "7":
            return false;
        default:
            return true;
    }
}
string PedirCpf()
{
    string tryCpf = "";
    Console.Write("Escreva seu CPF e aperte Enter: ");
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
        Console.Write("Digite um numero por favor: ");
        tryId = Console.ReadLine();
    }
    foreach (var item in listaContas)
    {
        if (item.NumeroConta == id)
        {
            return id;
        }
    }
    return 0;
}

void Depositar(int id)
{
    double valorDeposito = 0;
    Console.Write("Digite o valor a ser depositado: ");
    string tryValorDeposito = Console.ReadLine();
    while (!double.TryParse(tryValorDeposito, out valorDeposito))
    {
        Console.Write("Digite o valor a ser depositado novamente: ");
        tryValorDeposito = Console.ReadLine();
    }
    foreach (var item in listaContas)
    {
        if (item.NumeroConta == id)
        {
            item.Deposito(valorDeposito);
            Extrato extrato = new Extrato(valorDeposito, item, "Deposito");
            item.Extrato(extrato);
            listaExtrato.Add(extrato);
        }
        Console.WriteLine("Deposito realizado!");
        Console.WriteLine($"O valor de {valorDeposito} foi depositado");
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
        Console.Write("Digite o valor a ser retirado novamente: ");
        tryValorSaque = Console.ReadLine();
    }
    foreach (var item in listaContas)
    {
        if (item.NumeroConta == id)
        {
            try { item.Saque(valorSaque);
                    Extrato extrato = new Extrato(valorSaque, item, "Saque");
                    item.Extrato(extrato);
                    listaExtrato.Add(extrato);
            }
            catch (Exception e)
            {
                Console.WriteLine($"{e.Message}");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                Console.ReadLine();
                MainMenu();
                break;
            }
            Console.WriteLine("Saque realizado!");
            Console.WriteLine($"O saldo atual é: {item.Saldo}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            MainMenu();
            break;
        }
    }
}

void Extrato(int id)
{
    foreach (var item in listaExtrato)
    {
        if (item.ContaOrigem.NumeroConta == id)
        {
            Console.WriteLine("#####################");
            Console.WriteLine($"A conta:  {item.ContaOrigem.NumeroConta}");
            Console.WriteLine($"fez a movimentacao:  {item.Tipo}");
            if (item.ContaDestino != null){Console.WriteLine($"Para a conta:  {item.ContaOrigem.NumeroConta}");}
            Console.WriteLine($"de valor:  {item.Valor}");
            Console.WriteLine($"no dia:  {item.Date}");
            Console.WriteLine("#####################");
        }
        else
        {
            Console.WriteLine("DevinBank ainda não possui transações nessa Conta.");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
            Console.ReadLine();
            MainMenu();
        }
    }
    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
    Console.ReadLine();
    MainMenu();
}

void VerSimulacao(int id, string tipo)
{
    Console.Write("Bem vindo a simulação de investimento! \n");
    if (tipo == "ContaInvestimento") {
        
        Console.Write("Temos 3 tipos de aplicação:\n ");
        Console.Write("LCI 8% ano (minimo de 6 meses de retenção)\n");
        Console.Write("LCA 9% ano (minimo de 12 meses de retenção)\n");
        Console.Write("LCI 10% ano (minimo de 36 meses de retenção)\n");
    }
    if (tipo == "ContaPoupança") { Console.Write("Bem vindo a simulação de poupança "); }
   



    double valorInvestido = 0;
    Console.Write("Digite o valor a ser investido: ");
    string tryValorInvestido = Console.ReadLine();
    while (!double.TryParse(tryValorInvestido, out valorInvestido))
    {
        Console.Write("Digite o valor a ser investido novamente: ");
        tryValorInvestido = Console.ReadLine();
    }
    double meses = 0;
    Console.Write("Digite o tempo de rendimento: ");
    string tryMeses = Console.ReadLine();
    while (!double.TryParse(tryMeses, out meses))
    {
        Console.Write("Digite o tempo de rendimento novamente: ");
        tryMeses = Console.ReadLine();
    }
    if (tipo == "ContaPoupanca") 
    { 
    double result = ContaPoupanca.SimularPoupanca(valorInvestido, meses);
    Console.WriteLine("Simulação realizada!");
    Console.WriteLine($"O retorno da poupanca será de: {result.ToString("0.00")} reais");
    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
    Console.ReadLine();
    MainMenu();
    }
    if (tipo == "ContaInvestimento")
    {
        Console.Clear();
        Console.Write("Escolha o tipo de Aplicação:\n ");
        Console.WriteLine("1) LCI 8% ano (minimo de 6 meses de retenção)");
        Console.WriteLine("2) LCA 9% ano (minimo de 12 meses de retenção)");
        Console.WriteLine("3) CDB 10% ano (minimo de 36 meses de retenção)");
        Console.WriteLine("4) Voltar ao menu Inicial");
        Console.Write("\r\nSelect an option: ");

        switch (Console.ReadLine())
        {
            case "1":
                string tipoAplicacao = "";
                Conta contaInvestimento = listaContas.Find(i => i.NumeroConta == id);
                try { double result = ContaInvestimento.SimularInvestimento(valorInvestido, meses, "LCI");
                    Console.WriteLine("Simulação realizada!");
                    Console.WriteLine($"O retorno da poupanca será de: {result.ToString("0.00")} reais");
                    Console.WriteLine("Quer fazer o investimento?");
                    Console.WriteLine("1) Sim, quero investir.");
                    Console.WriteLine("2) Voltar ao menu Inicial");
                    Console.Write("\r\nSelect an option: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();
              
                }
               
                switch (Console.ReadLine())
                {
                    case "1":
                        tipoAplicacao = "LCI";
                        break;
                    case "2":
                        MainMenu();
                        break;
                    default:
                        break;
                }
                try { contaInvestimento.DepositoInvestimento(valorInvestido, tipoAplicacao);
                    Extrato extrato = new Extrato(valorInvestido, contaInvestimento, $"Investimento{tipoAplicacao}");
                    listaExtrato.Add(extrato);
                    contaInvestimento.Extrato(extrato);
                    Console.WriteLine("Deposito realizado!");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();


                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();
                }
                break;
           case "2":
                string tipoAplicacao2 = "";
                Conta contaInvestimento2= listaContas.Find(i => i.NumeroConta == id);
                try
                {
                    double result = ContaInvestimento.SimularInvestimento(valorInvestido, meses, "LCA");
                    Console.WriteLine("Simulação realizada!");
                    Console.WriteLine($"O retorno da poupanca será de: {result.ToString("0.00")} reais");
                    Console.WriteLine("Quer fazer o investimento?");
                    Console.WriteLine("1) Sim, quero investir.");
                    Console.WriteLine("2) Voltar ao menu Inicial");
                    Console.Write("\r\nSelecione uma opção: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.WriteLine("Algo deu errado");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();

                }

                switch (Console.ReadLine())
                {
                    case "1":
                        tipoAplicacao2 = "LCA";
                        break;
                    case "2":
                        MainMenu();
                        break;
                    default:
                        break;
                }
                try
                {
                    contaInvestimento2.DepositoInvestimento(valorInvestido, tipoAplicacao2);
                    Extrato extrato = new Extrato(valorInvestido, contaInvestimento2, $"Investimento{tipoAplicacao2}");
                    listaExtrato.Add(extrato);
                    contaInvestimento2.Extrato(extrato);
                    Console.WriteLine("Deposito realizado!");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();


                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();
                }
                break; ;
            case "3":
                string tipoAplicacao3 = "";
                Conta contaInvestimento3 = listaContas.Find(i => i.NumeroConta == id);
                try
                {
                    double result = ContaInvestimento.SimularInvestimento(valorInvestido, meses, "LCI");
                    Console.WriteLine("Simulação realizada!");
                    Console.WriteLine($"O retorno da poupanca será de: {result.ToString("0.00")} reais");
                    Console.WriteLine("Quer fazer o investimento?");
                    Console.WriteLine("1) Sim, quero investir.");
                    Console.WriteLine("2) Voltar ao menu Inicial");
                    Console.Write("\r\nSelecione uma opção: ");
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();

                }

                switch (Console.ReadLine())
                {
                    case "1":
                        tipoAplicacao3 = "CDB";
                        break;
                    case "2":
                        MainMenu();
                        break;
                    default:
                        break;
                }
                try
                {
                    contaInvestimento3.DepositoInvestimento(valorInvestido, tipoAplicacao3);
                    Extrato extrato = new Extrato(valorInvestido, contaInvestimento3, $"Investimento{tipoAplicacao3}");
                    contaInvestimento3.Extrato(extrato);
                    listaExtrato.Add(extrato);
                    Console.WriteLine("Deposito realizado!");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();


                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
                    Console.ReadLine();
                    MainMenu();
                }
                break;
            case "4":
                break;
            default:
                break;
        }
    }
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

void Transferir(int id)
{
    int idTransferencia = PedirIdTranferencia();
    int PedirIdTranferencia()
    {
        int idTransferencia = 0;
        Console.Write("Digite o numero da conta que receberá a transferencia e aperte Enter: ");
        string tryId = Console.ReadLine();

        while (!int.TryParse(tryId, out idTransferencia))
        {
            Console.Write("Digite o numero da conta que receberá a transferencia e aperte Enter: ");
            tryId = Console.ReadLine();
        }
        foreach (var contaTransferencia in listaContas)
        {
            if (contaTransferencia.NumeroConta == idTransferencia)
            {
                return idTransferencia;
            }
        }
        return 0;
    }
    if (idTransferencia == 0)
    {
        Console.WriteLine("Conta inexistente aperte qualquer tecla para voltar ao menu anterior");
        Console.ReadLine();
        MainMenu();
    }
    Conta contaSaida = listaContas.Find(i => i.NumeroConta == id);
    Conta contaEntrada = listaContas.Find(i => i.NumeroConta == idTransferencia);
    double valorTransferencia = 0;
    Console.Write("Digite o valor a ser transferido: ");
    string tryValorTransferencia = Console.ReadLine();
    while (!double.TryParse(tryValorTransferencia, out valorTransferencia))
    {
        Console.Write("This is not valid input. Please enter an integer value: ");
        tryValorTransferencia = Console.ReadLine();
    }
    
    try
    {
        contaSaida.Transferencia(valorTransferencia, contaEntrada);
        Extrato extrato = new Extrato(valorTransferencia, contaSaida, contaEntrada, "Transferência");
        listaExtrato.Add(extrato);
        contaSaida.Extrato(extrato);
    }
    catch (Exception e)
    {
        Console.WriteLine($"{e.Message}");
        Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
        Console.ReadLine();
        MainMenu();

    }
    Console.WriteLine("Transferencia realizada!");
    Console.WriteLine($"O saldo atual é: {contaSaida.Saldo}");
    Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
    Console.ReadLine();
    MainMenu();



}
void AtualizarCadastro(int id) 
{
    Conta contaMudanca = listaContas.Find(i => i.NumeroConta == id);
    double rendaMensal = 0;

    Console.Write("Escreva seu nome e aperte Enter: ");
    string nome = Console.ReadLine();
    while (nome == "")
    {
        Console.Write("Escreva seu nome novamente e aperte Enter: ");
        nome = Console.ReadLine();
    }

    Console.Write("Escreva seu endereço e aperte Enter: ");
    string endereco = Console.ReadLine();
    while (nome == "")
    {
        Console.Write("Escreva seu endereço novamente e aperte Enter: ");
        endereco = Console.ReadLine();
    }

    Console.Write("Escreva sua renda mensal e aperte Enter: ");
    string tryRendaMensal = Console.ReadLine();
    while (!double.TryParse(tryRendaMensal, out rendaMensal))
    {
        Console.Write("Escreva sua renda mensal novamente e aperte Enter: ");
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
            contaMudanca.AlterarDadosCadastrais(nome, endereco, rendaMensal, "001 - Florianópolis");
            Console.WriteLine("Alteração realizada!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            MainMenu();
            break;
        case "2":
            contaMudanca.AlterarDadosCadastrais(nome, endereco, rendaMensal, "002 - São José");
            Console.WriteLine("Alteração realizada!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            MainMenu();
            break;
        case "3":
            contaMudanca.AlterarDadosCadastrais(nome, endereco, rendaMensal, "003 - Biguaçu");
            Console.WriteLine("Alteração realizada!");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu inicial");
            Console.ReadLine();
            MainMenu();
            break;
        case "4":
            break;
        default:
            break;
    }
}
bool AcessarRelatoriosMenu()
{
    Console.Clear();
    Console.WriteLine("Tipo de Relatorio:");
    Console.WriteLine("1) Todas as contas do DevinBank");
    Console.WriteLine("2) Contas Negativadas");
    Console.WriteLine("3) Capital total DevinBank ");
    Console.WriteLine("4) Transaçoes por cliente");
    Console.WriteLine("5) Voltar ao menu principal");
    Console.Write("\r\nSelect an option: ");
    switch (Console.ReadLine())
    {
        case "1":
            if(listaContas.Count == 0) 
            { Console.WriteLine("DevinBank ainda não possui contas.");
              Console.WriteLine("Aperte qualquer tecla para voltar ao menu ´relatorios");
              Console.ReadLine();
              AcessarRelatoriosMenu();
            }
            Console.WriteLine("Abaixo a lista com todas as contas do DevinBank: ");
            foreach (var item in listaContas)
            {
                
                Console.WriteLine("#####################");
                Console.WriteLine($"Conta:  {item.NumeroConta}");
                Console.WriteLine($"Tipo de conta:  {item.GetType().Name}");
                Console.WriteLine($"Atrelada ao CPF:  {item.CPF}");
                Console.WriteLine($"Com saldo:  {item.Saldo}");
                Console.WriteLine("#####################");
            }
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu ´relatorios");
            Console.ReadLine();
            AcessarRelatoriosMenu();
            return true;
        case "2":
            if (listaContas.Count == 0)
            {
                Console.WriteLine("DevinBank ainda não possui contas.");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
                Console.ReadLine();
                MainMenu();
            }
            foreach (var item in listaContas)
            {
                if (Math.Sign(item.Saldo) == Math.Sign(-1))
                {
                    Console.WriteLine("#####################");
                    Console.WriteLine($"A conta:  {item.NumeroConta}");
                    Console.WriteLine($"Está negativada com o saldo: {item.Saldo}");
                    Console.WriteLine("#####################");
                }
            }
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
            Console.ReadLine();
            MainMenu();
            return true;
        case "3":
            double capitalTotal = 0;
            if (listaContas.Count == 0)
            {
                Console.WriteLine("DevinBank ainda não possui contas.");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
                Console.ReadLine();
                MainMenu();
            }
            foreach (var item in listaContas)
            { 
                capitalTotal +=item.Saldo;
            
            }
            Console.WriteLine("#####################");
            Console.WriteLine($"Capital total do DevinBank:  {capitalTotal}");
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
            Console.ReadLine();
            MainMenu();
            return true;
        case "4":
            string cPF = PedirCpf();

            if (listaExtrato.Count == 0)
            {
                Console.WriteLine("DevinBank ainda não possui transações.");
                Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
                Console.ReadLine();
                MainMenu();
            }
            foreach (var item in listaExtrato)
            {
                if (item.ContaOrigem.CPF == cPF)
                {
                    Console.WriteLine("#####################");
                    Console.WriteLine($"A conta:  {item.ContaOrigem.NumeroConta}");
                    Console.WriteLine($"fez a movimentacao:  {item.Tipo}");
                    if (item.ContaDestino != null) { Console.WriteLine($"Para a conta:  {item.ContaOrigem.NumeroConta}"); }
                    Console.WriteLine($"de valor:  {item.Valor}");
                    Console.WriteLine($"no dia:  {item.Date}");
                    Console.WriteLine("#####################");
                }
                else {
                    Console.WriteLine("DevinBank ainda não possui transações nesse CPF.");
                    Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
                    Console.ReadLine();
                    MainMenu();
                }
            }
            Console.WriteLine("Aperte qualquer tecla para voltar ao menu principal");
            Console.ReadLine();
            MainMenu();
            return true;
        case "5":
            return false;
        default:
            return true;
    }
}
