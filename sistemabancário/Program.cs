using NuBank;

class Bradesco{
    public static void Main()
    {
        Console.WriteLine("Digite o nome do titular da conta:");
        string TiTalar = Console.ReadLine();
         ContaCorrente Santander = new ContaCorrente(TiTalar,100);

        Console.Clear(); 
        Console.WriteLine("Olá, e bem vindo! Em quê podemos ajudar?");
        Console.WriteLine("----------------------------------------");
        Console.Clear();
        Console.WriteLine("1. Consultar Saldo");
        Console.WriteLine("2. Depósito");
        Console.WriteLine("3. Saque");
        Console.WriteLine("0. Fechar o sistema");
        string opcao = "";
        

        do{
            opcao = Console.ReadLine();

            switch (opcao)
            {
                case "0":
                    Console.WriteLine("Obrigado e volte sempre!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    Santander.ConsultarSaldo();
                    break;
                case "2":
                    Santander.Depositar();
                    break;
                case "3":
                    Santander.Sacar();
                    break;
                default:
                    Console.WriteLine("Opção inválida !");
                    break;
            }
        } while (opcao != "0");
    }}

        
