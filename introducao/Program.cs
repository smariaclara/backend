/*Somente declaramos a variável como inteira e não atribuímos valor*/
int num1;
/*Declarando uma variável do tipo inteira e atribuindo o valor 5*/
int num2 = 5;
/*Declarando uma variável do tipo string*/
string nomeAluno;
/*Variável do tipo lógica (verdadeiro ou falso)*/
bool resultado = true;
/*Variável do tipo valor com casas decimais (para valores mais precisos)*/
double coordenada = 1.80;
/*Variável do tipo decimal (utilizada principalmente para valores monetários)*/
decimal valor = 1.80M;
/**/
int idade = 16;
string nome = "Maria";
Console.WriteLine($"Meu nome é {nome} e tenho {idade} anos");
Console.WriteLine("Em que cidade você nasceu?");
/*Recebndo uma informação do usuário e atribuindo na variável cidade*/
string cidade = Console.ReadLine();
Console.WriteLine($"Você nasceu em {cidade}");

int novaIdade = idade + 5;
int anoNascimento = 2023 - idade;
Console.WriteLine($"Você nasceu em {anoNascimento} e daqui cinco anos terá {novaIdade}");