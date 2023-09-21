using System.Collections.Generic;
using Sesi.Models;
public class Program{
public static void Main(){
    //Criando uma lista de números inteiros
    List<int> listaNumeros = new List<int>();
    //Adicionando elementos a lista
    listaNumeros.Add(13); /*posição [0]*/
    listaNumeros.Add(15); /*posição [1]*/
    listaNumeros.Add(7);  /*posição [2]*/
    //Contando a qaumtidade de elementos em nossa lista
    Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");
    //Acessando os dados da lista pelo índice
    Console.WriteLine(listaNumeros[1]);
    listaNumeros.Add(3); /*posição [3]*/
    Console.WriteLine($"Neste momento temos {listaNumeros.Count} números");
    Console.WriteLine("-------------------------------------------------------");

    //*Criem uma lista de nomes e adicionem alguns nomes a ela, e exibam a quantidade de nomes que contém na lista *//

    List<string> listaNomes = new List<string>();
    listaNomes.Add("Letícia");
    listaNomes.Add("Ana Carolina");
    listaNomes.Add("Valeska");
    listaNomes.Add("Alyssa");
    listaNomes.Add("Maria Beatriz");
    Console.WriteLine($"Neste momento temos {listaNomes.Count} nomes na lista");
    listaNomes.Add("Rafael");
    listaNomes.Add("João Paulo");
    listaNomes.Add("Ricardo");
    listaNomes.Add("Renato");
    
    Console.WriteLine($"Neste momento temos {listaNomes.Count} nomes na lista");
    foreach (string item in listaNomes){
        Console.WriteLine(item);
    }
    Console.WriteLine("-------------------------------------------------------");

    List<int> numeros = new List<int>{1, 2, 3, 4, 5, 6, 7, 8, 9};
    numeros.Add(10);

    //Iterando sobre todos os itens da lista
    foreach (int item in numeros){
        Console.WriteLine(item);
    }
    
    //Criando uma nova lista com objetos da Classe Aluno
    List<Aluno> listaAlunos = new List<Aluno>();

    //Adicionando um novo aluno à listaAluno
    Aluno novoAluno = new Aluno("Rayssa", 19);
    listaAlunos.Add(novoAluno);

     listaAlunos.Add(new Aluno("Natália", 24));
     listaAlunos.Add(new Aluno("Bruna", 23));
     listaAlunos.Add(new Aluno("Pietra", 12));

     Console.WriteLine("Lista de alunos:");
     foreach (Aluno item in listaAlunos){
        Console.WriteLine($"{item.nome}, {item.idade}");
     }

     //Criando uma nova lista, filtrando e ordenando por nome LINQ utilizando Sintaxe de Consulta
     var consulta = from aluno in listaAlunos
                     where aluno.idade > 18
                     orderby aluno.nome
                     select aluno;
                    
    Console.WriteLine("Alunos com mais de 18 anos:");
     foreach (var item in consulta){
        Console.WriteLine($"{item.nome}, {item.idade}");
     }

     //LINQ utilizando Sintaxe de método
     var metodo = listaAlunos
                            .Where(aluno => aluno.idade < 18)
                            .OrderBy(aluno => aluno.nome);

    Console.WriteLine("Alunos com menos de 18 anos:");
     foreach (var item in metodo){
        Console.WriteLine($"{item.nome}, {item.idade}");
     }
            
}}