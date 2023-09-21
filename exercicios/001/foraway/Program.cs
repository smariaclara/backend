class Farfetch
{
    public static void Main()
    {
        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine($"Estou passando pela {i}ª vez no bloco");
        }

        //Criando uma tabuada utilizando o for
        int num = 5;

        for (int cont = 1; cont <= 10; cont++)
        {
            Console.WriteLine($"{num} x {cont} = {cont * num}");
        }

        //Declarando um vetor do tipo inteiro com 4 espaços
        int[] notas = new int[4];
        //Declarar um vetor atribuindo valores
        string[] meses = {"Jan.", "Fev."};

        int[] alunos = new int[6];
        alunos[4] = 3;
        alunos[5] = 11;
        alunos[3] = 7;
        alunos[0] = 20;
        alunos[2] = 8;
        alunos[1] = 12;

        int soma = 0;
        int maior = 0;
        int menor = 10000;

        for (int i = 0; i < alunos.Length; i++)
        {
            Console.WriteLine($"Aluno na posição {i} tem i valor {alunos[i]}");
        }

        foreach (int eu in alunos)
        {
            soma = soma + eu;
            if (eu > maior)
            {
                maior = eu;
            }
            if (eu < menor)
            {
                menor = eu;
            }
            Console.WriteLine($"A soma é {soma}, o maior é {maior} e o menor é {menor}");
            Array.Sort(alunos);
            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine($"Aluno na posição {i} tem o valor {alunos[i]}");
            }
        }
    }
}