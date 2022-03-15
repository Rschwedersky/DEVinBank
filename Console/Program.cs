using DEVinBank;
 
            bool showMenu = true;
            
            while (showMenu)
            {
                 showMenu = MainMenu();
            }
       
         static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Abrir uma conta");
            Console.WriteLine("2) Operações");
            Console.WriteLine("2) Relatórios");
            Console.WriteLine("3) Exit");
            Console.Write("\r\nSelect an option: ");

            switch (Console.ReadLine())
            {
                case "1":
                 AbrirContaMenu();
                 return true;
                case "2":
                    RemoveWhitespace();
                    return true;
                case "3":
                    return false;
                default:
                    return true;
            }
        }

         static string CaptureInput()
        {
            Console.Write("Enter the string you want to modify: ");
            return Console.ReadLine();
        }

         static void ReverseString()
        {
            Console.Clear();
            Console.WriteLine("Reverse String");

            char[] charArray = CaptureInput().ToCharArray();
            Array.Reverse(charArray);
            DisplayResult(String.Concat(charArray));
        }

        static void RemoveWhitespace()
        {
            Console.Clear();
            Console.WriteLine("Remove Whitespace");

            DisplayResult(CaptureInput().Replace(" ", ""));
        }

         static void DisplayResult(string message)
        {
            Console.WriteLine($"\r\nYour modified string is: {message}");
            Console.Write("\r\nPress Enter to return to Main Menu");
            Console.ReadLine();
        }

static bool AbrirContaMenu()
{
    string nome = "";
    string tryCpf = "";
    string cPF = "";
    string endereco = "";
    string tryRendaMensal = "";
    decimal rendaMensal = 0;
    string agencia = "";
    

    Console.Clear();
    Console.Write("Type your name, and then press Enter: ");
    nome = Console.ReadLine();
    
    Console.Write("Type your CPF, and then press Enter: ");
    tryCpf = Console.ReadLine();
    CPFCNPJ.IMain testaCpf = new CPFCNPJ.Main();
    while (testaCpf.IsValidCPFCNPJ(tryCpf) == false)
    {
        Console.Write("CPF invalido! repita seu CPF: ");
        tryCpf = Console.ReadLine();
    }
    cPF = tryCpf;

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
    Console.WriteLine("4) 003 - Biguaçu");
    Console.WriteLine("4) Voltar");
    Console.Write("\r\nSelect an option: ");
    switch (Console.ReadLine())
    {
        case "1":
            Conta conta=new Conta(nome, cPF,endereco,rendaMensal, "001 - Florianópolis");
            return true;
        case "2":
            Conta conta2 = new Conta(nome, cPF, endereco, rendaMensal, "002 - São José");
            return true;
        case "3":
            Conta conta3 = new Conta(nome, cPF, endereco, rendaMensal, "003 - Biguaçu");
            return true;
        case "4":
            return false;
        default:
            return true;
    }
}