using ListaParaFazer.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaParaFazer.Data.Mapping
{
    public class TarefaModelMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TarefaModel> builder)
        {
            builder.ToTable("ParaFazer");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();
        }
    }
}