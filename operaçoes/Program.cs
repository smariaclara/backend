Console.WriteLine("Digite o valor de X:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor de Y:");
int y = int.Parse(Console.ReadLine());

/*Exemplos de operadores aritméticos*/
int soma = x + y;
int subtraçao = x - y;
int multiplicaçao = x * y;
int divisao = x / y;
int resto = x % y;
int restoDiv2 = x % 2;

Console.WriteLine("Soma: " + soma);
Console.WriteLine("Subtração: " + subtraçao);
Console.WriteLine("Multiplicação: " + multiplicaçao);
Console.WriteLine("Divisão: " + divisao);
Console.WriteLine("Resto : " + resto);

if(restoDiv2 == 0)
{
    Console.WriteLine($"{x} é par");
} else{
    Console.WriteLine($"{x} é ímpar");
}

/*Operador ternário*/
// condição ? se verdade : senão
string ePar = (restoDiv2 == 0) ? " par " : "ímpar";

/*Aprendendo Switch Case*/
int diaSemana = 4;
switch(diaSemana){
    case 1:
    Console.WriteLine("Hoje é Domingo!");
    break;
    case 2:
    Console.WriteLine("Hoje é Segunda-feira!");
    break;
    case 3:
    Console.WriteLine("Hoje é Terça-Feira!");
    break;
    case 4:
    Console.WriteLine("Hoje é Quarta-Feira!");
    break;
    case 5:
    Console.WriteLine("Hoje é Quinta-Feira!");
    break;
    case 6:
    Console.WriteLine("Hoje é Sexta-Feira!");
    break;
    case 7:
    Console.WriteLine("Hoje é Sábado!");
    break;
}
