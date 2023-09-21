class Sesi
{
/*Método Main é o ponto de entrada de um programa em C#*/
    public static void Main()
    {
        Console.WriteLine("Estou no método Main");
        Metodo();
        ImprimeDataHora();
        ImprimeDataHora();

        int resultadoSoma = Somar(6, 1);
        Console.WriteLine(resultadoSoma);

        ContagemRegressiva(5);

        JogoQueNrSouEu();
    }
    public static void Metodo()
    {
        Console.WriteLine("Estou no método/função");
    }
    public static void ImprimeDataHora()
    {
        Console.WriteLine(DateTime.Now.ToShortDateString());
        Console.WriteLine(DateTime.Now.Hour.ToString());
        Console.WriteLine(DateTime.Now.ToString());
    }
    public static void ContagemRegressiva(int n)
    {
        while(n >= 0){
            Console.WriteLine(n);
            n--; 
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine("BOOOOOOOOOOM!");
    }
    public static void JogoQueNrSouEu(){
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("           Bem vindo ao Jogo               ");
        Console.WriteLine("Sorteei um nº de 1 a 20, tente adivinha-lo");
        Console.WriteLine("* * * * * * * * * * * * * * * * * * * * * *");
        Console.WriteLine("");

        Random rnd = new Random();
        int nrSorteado = rnd.Next(20);
        int nrDigitado = 1;

        do{
            Console.WriteLine("Digite um nº");
            nrDigitado = int.Parse(Console.ReadLine());
            if (nrDigitado > nrSorteado)
            Console.WriteLine("O número digitado é MAIOR que o sorteado");
            else if(nrDigitado < nrSorteado)
            Console.WriteLine("O número digitado é MENOR que o sorteado");
        }while (nrDigitado != nrSorteado);
        Console.WriteLine("Parabéns! Você acertou!");
    }
    public static int Somar(int n1, int n2)
    {
        int soma = n1+ n2;
        return n1 + n2; 
    }
}