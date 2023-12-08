using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace _atividadeCrud.Models
{
//DataAnnotation de como será criado o nome da tabela no BD
[Table("Joias")]
public class BrincoColarPulseira
{
[Key] //Falando para o BD que este atributo será uma chave
public int BrincoColarPulseiraId { get; set; }
[Required(ErrorMessage="Nome é obrigatório")]
[MaxLength(200, ErrorMessage = "Descrição tem que exceder {1} caracteres")]
public string Nome { get; set; }
public string Descricao { get; set; }
public string Imagem { get; set; }
public bool Ativo { get; set; }
public int CategoriaId { get; set; }
public virtual Categoria Categoria { get; set; }
}
}