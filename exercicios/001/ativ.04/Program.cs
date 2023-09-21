class Contas{
public static void Main()
    {
        Console.WriteLine();
        

        int resultadoVezes = MaisDoMesmo(10, 7);
        Console.WriteLine(resultadoVezes);

        int resultadoDividir = CinquentaPorCento(10, 2);
        Console.WriteLine(resultadoDividir);

        TabuadaComWhile(5);

        SomaComDoWhile(9);
    }

    public static int MaisDoMesmo(int n1, int n2)
    {
        int multiplicaçao = n1 * n2;
        return n1 * n2;
    }

    public static int CinquentaPorCento(int n1, int n2)
    {
        int divisao = n1 / n2;
        return n1 / n2;
    }

     public static void TabuadaComWhile(int n)
    {
        Console.WriteLine("Digite o valor ao qual quer calcular a multiplicação:");
        int contador=0;
       while(contador <= 200){
            Console.WriteLine($"{contador}º execução: {n} x {contador} = {n * contador}");
            contador++;
        }
        
    }

    public static void SomaComDoWhile(int n)
    {
        int maior = 0;
        int menor = 10000;
        int soma = 0;

        do{
            Console.WriteLine("Informe um número positivo, negativo para encerrar");
            int num = int.Parse(Console.ReadLine());

            if(num > maior)
            maior = num;

            if (num < menor && num > 0)
            menor = num;

            if(num >0)
            soma = soma + num;
        }while(num < 0);
        Console.WriteLine($"Menornº {menor} e mao número (maior. A soma de maior e menor é {soma})");
        }
        
    }
    

