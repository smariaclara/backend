public class Programaçao{
    public static void Main(){
        var pessoaA = new{
            nome = "Maria Joaquina",
            idade = 7
        };
        var pessoaB = new{
            nome = "Cirilo",
            idade = 8
        };
        var pessoaC = new{
            nome = "Valéria",
            idade = 7
        };
        Console.WriteLine($"A pessoa 1 se chama {pessoaA.nome} e a pessoa 2 se chama {pessoaB.nome}");

        Console.WriteLine("Digite a marca do carro");
        string marquete = Console.ReadLine();
        Console.WriteLine("Digite o modelo do carro");
        string modelete = Console.ReadLine();
        Console.WriteLine("Digite a cor do carro");
        string corete = Console.ReadLine();

        var carroA = new{
            marca = marquete,
            modelo = modelete,
            cor = corete
        };
       
       Console.WriteLine($"O carro é o {carroA.modelo}, de cor {carroA.cor}. A marca que fabrica é {carroA.marca}");
    }
}