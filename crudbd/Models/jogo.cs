using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace crudbd.Models
{
    //DataAnnotation de como será criado o nome na tabela do BD
    [Table("Jogos")]
    public class jogo
    {
        [Key] /*Falando para o BD que este atributo será uma chave*/
        public int JogoId { get; set; }
        [Required(ErrorMessage="Nome é obrigatório")]
        [Display(Name="Nome do jogo")]
        public string Nome{ get; set; }
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public bool Ativo { get; set; }
    }
}