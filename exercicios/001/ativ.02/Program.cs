Console.WriteLine("Digite sua placa");
string placa = Console.ReadLine();

string final = placa.Substring(placa.Length - 3, 1);
Console.WriteLine(final);

switch(final){
    case "1":
    Console.WriteLine("O dia do seu rodízio é Segunda-Feira!");
    break;
    case "2":
    Console.WriteLine("O dia do seu rodízio é Segunda-Feira!");
    break;
    case "3":
    Console.WriteLine("O dia do seu rodízio é Terça-Feira!");
    break;
    case "4":
    Console.WriteLine("O dia do seu rodízio é Terça-Feira!");
    break;
    case "5":
    Console.WriteLine("O dia do seu rodízio é Quarta-Feira!");
    break;
    case "6":
    Console.WriteLine("O dia do seu rodízio é Quarta-Feira!");
    break;
    case "7":
    Console.WriteLine("O dia do seu rodízio é Quinta-Feira!");
    break;
    case 8:
    Console.WriteLine("O dia do seu rodízio é Quinta-Feira!");
    break;
    case 9:
    Console.WriteLine("O dia do seu rodízio é Sexta-Feira!");
    break;
    case 0:
    Console.WriteLine("O dia do seu rodízio é Sexta-Feira!");
    break;
}