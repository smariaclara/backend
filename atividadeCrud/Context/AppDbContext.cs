using Microsoft.EntityFrameworkCore;
using _atividadeCrud.Models;
namespace _atividadeCrud.Context
{
public class AppDbContext : DbContext
{
public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
{
}
//No meu DbSet carregará todos os jogos salvos no banco de dados
public DbSet<BrincoColarPulseira> Joias {get; set;}
public DbSet<Categoria> Categorias {get; set;}
public DbSet<Usuario> Usuarios { get; set;}
}
}