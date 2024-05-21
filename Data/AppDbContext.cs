using ListaParaFazer.Data.Mapping;
using ListaParaFazer.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaParaFazer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TarefaModel> Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaModelMap());
        }

    }
}