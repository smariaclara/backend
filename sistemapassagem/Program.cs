class Reunidas
{
    public static string[] poltronas = new string[51];
    public static void Main()
    {
        Console.Clear(); /*Limpa como o CLS na visualização de console*/
        Console.WriteLine("Bem-vindo ao Bus Lightyear");
        Console.WriteLine("´´´´´´´´´´´´´´´´´´´´´´´´´´´");
        Console.WriteLine("Contamos com 50 lugares disponíveis");
        Menu();
    }

    public static void Menu()
    {
        string opçao = "";
        do
        {
            Console.WriteLine("******************** M E N U *********************");
            Console.WriteLine("1. Para comprar passagem");
            Console.WriteLine("2. Para ver poltronas dispóníveis");
            Console.WriteLine("3. Para ver quantas poltronas dispóníveis");
            Console.WriteLine("4. Lista de passageiros da viagem");
            Console.WriteLine("0. Para fechar o sistema");
            opçao = Console.ReadLine();
            Console.Clear();

            switch (opçao)
            {
                case "0":
                    Console.WriteLine("Obrigado e volte sempre!");
                    System.Threading.Thread.Sleep(2000);
                    break;
                case "1":
                    ComprarPassagem();
                    break;
                case "2":
                    PoltronasDisponiveis();
                    break;
                case "3":
                    TotalQAT();
                    break;
                case "4":
                    QuemVai();
                    break;
                default:
                    Console.WriteLine("Opção inválida !");
                    break;
            }
        } while (opçao != "0");
    }

    public static void ComprarPassagem()
    {
        Console.WriteLine("Quantas passagens deseja comprar?");
        int nrPassagem = int.Parse(Console.ReadLine());

        for (int i = 1; i <= nrPassagem; i++)
        {
            Console.WriteLine($"Digite a poltrona da {i}º passagem");
            int nrPoltrona = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o nome do passageiro");
            string nome = Console.ReadLine();
            MarcarPoltrona(nrPoltrona, nome);
        }
    }
    public static void MarcarPoltrona(int nrPoltrona, string nome)
    {
        poltronas[nrPoltrona] = nome;
    }
    public static void PoltronasDisponiveis()
    {
        Console.WriteLine("Lista de poltronas disponíveis");
        for (int i = 1; i <= 50; i++)
        {
            if (poltronas[i] == null)
            {
                Console.WriteLine($"Nº {i}");
            }
        }
    }
    public static void TotalQAT()
    {
        int ainda = 50;

        foreach (string eu in poltronas)
        {
            if (eu != null){
                ainda = ainda -1;
            } 
        }

        Console.WriteLine($"Ainda há {ainda} poltronas disponíveis");
    }
     public static void QuemVai()
    {
        Console.WriteLine("Lista de passageiros");
        for (int i = 1; i <= poltronas.Length; i++)
        {
            if (poltronas[i] != null)
            {
                Console.WriteLine($"{poltronas[i]}");
            }
        }
    }
}
