//O namespace é um nome em que usaremos para fazer referência em usarmos
namespace Sesi.Model
{
    public class Aluno
    {
        //Declarando ps atributos (propriedades) da classe aluno
        public string nome { get; set; }
        public int idade { get; set; }
        public string turma { get; set; }
        public int nrFaltas { get; set; }


        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {nome}, eu tenho {idade} anose estudo na turma {turma}, e tenho {nrFaltas} faltas");
        }
        public void AdicionarFaltas(int nr){
            Console.WriteLine($"O aluno {nome} faltou hoje e somou {nr}");
            nrFaltas = nrFaltas+ nr;
        }
        public void ResumoFaltas(){
            Console.WriteLine($"O aluno {nome} tem {nrFaltas}");
        }
        
    }


}