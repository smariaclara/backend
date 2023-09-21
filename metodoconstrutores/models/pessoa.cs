namespace Gisele{
    public class humano{
        private string nome { get; set; }
        private int idade { get; set; }

        public humano(string nome, int idade) {
            this.nome = nome;
            this.idade = idade;
        }
        public void TS(){
            Console.WriteLine($"{nome} está cantando");
        }
    }
}