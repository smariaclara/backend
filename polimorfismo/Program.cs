//Classe "pai" que será herdada (das outras classes filhas) ou SUPERCLASSE
class Maroon5{
    public string cor { get; set; }
    public virtual void EmitirSom(){
        Console.WriteLine($"Animal da cor {cor} fazendo algum som");
    }
}

//Classe filha que herdará da classe Maroon5
class Athena : Maroon5
{
    //Sobescrevendo o método EmitirSom()
    public override void EmitirSom(){
        Console.WriteLine($"O cachorro da cor {cor} está latindo");
    }
}

class Cirilo : Maroon5
{
    public override void EmitirSom(){
        Console.WriteLine($"O gato da cor {cor} está miando");
    }
    public void Ronronar(){
        Console.WriteLine("Você fez carinho no gato e ronronou");
    }
}

class deTV{
    public static void Main(){
        Maroon5 LariDog = new Maroon5();
        LariDog.cor = "branca";
        LariDog.EmitirSom();
        Athena Bella = new Athena();
        Bella.cor = "marrom";
        Bella.EmitirSom();
        Cirilo Mingau = new Cirilo();
        Mingau.cor = "preta";
        Mingau.EmitirSom();
        Mingau.Ronronar();
    }
}
