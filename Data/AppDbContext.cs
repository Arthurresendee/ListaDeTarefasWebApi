using ListaParaFazer.Data.Mapping;
using ListaParaFazer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListaParaFazer.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TarefaModel> TB_Tarefas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new TarefaModelMap());
        }

    }
}