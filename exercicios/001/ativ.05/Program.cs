class ListaDoChurrasco
{
    public static void Main(){
        Churras();
    }

    public static void Churras()
    {
        string[] festanoape = new string[6];
        festanoape[0] = "Carne 3kg";
        for(int i = 0; i < festanoape.Length; i++)
        {
            Console.WriteLine("Informe o produto");
            string almoçojanta = Console.ReadLine();
            festanoape[i] = almoçojanta;
        }
        Array.Sort(festanoape);

        foreach(string item in festanoape)
            Console.WriteLine($"Item {item}");
        }
  
     public static void SonhosdeConsumo(){
        string[] IHAD = new string[3];
        int[] realidade = new int[3];
        int soma = 0;

        for(int i=0; i < IHAD.Length; i++){
            Console.WriteLine("Informe o sonho");
            string sonho = Console.ReadLine();
            IHAD[i] = sonho;

            Console.WriteLine("Informe o valor");
            int valor = Console.ReadLine();
            realidade[i] = valor;
        }
    
    foreach(int item in IHAD)
    soma += item;

    Console.WriteLine($"Seus sonhos custarão R$ {soma}");
    
    }  }