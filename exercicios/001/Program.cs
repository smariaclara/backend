Console.WriteLine("Informe o nome do aluno:");
string aluno = Console.ReadLine();

Console.WriteLine("Digite a nota 1:");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Informe a segunda nota:");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("3ª nota:");
int h = int.Parse(Console.ReadLine());

int media = (x + y + h) / 3;

if(media >= 7)
{
    Console.WriteLine($"{aluno} foi aprovado com nota {media}! Parabéns!");
} else{
    Console.WriteLine($"{aluno} ficou com {media}! Ele foi REPROVADO!");
}