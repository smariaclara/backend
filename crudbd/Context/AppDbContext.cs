using Microsoft.EntityFrameworkCore;
using crudbd.Models;

namespace crudbd.Models.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){

        }
        public DbSet<jogo> Jogos {get; set;}
    }
}