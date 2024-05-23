using ListaParaFazer.Models;
using ListaParaFazer.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace ListaParaFazer.Data.Mapping
{
    public class TarefaModelMap : IEntityTypeConfiguration<TarefaModel>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TarefaModel> builder)
        {
            builder.ToTable("TB_Tarefas");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd();

            builder.Property(x => x.Title)
                .HasColumnName("Title")
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired(false);

            builder.Property(x => x.Descricao)
                .HasColumnName("Descricao")
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .IsRequired(false);

            builder.Property(x => x.DiasParaRealizar)
                .HasColumnName("DiasParaRealizar")
                .HasColumnType("int")
                .IsRequired(false);

            builder.Property(c => c.DataInicial)
                .HasColumnName("DataInicial")
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValue(DateTime.Now.ToUniversalTime())
                .IsRequired(false);

            builder.Property(c => c.DataFinal)
                .HasColumnName("DataFinal")
                .HasColumnType("SMALLDATETIME")
                .HasDefaultValue(DateTime.Now.ToUniversalTime().AddDays(1))
                .IsRequired(false);

            builder.Property(x => x.Realizada)
                .HasColumnName("Realizada")
                .HasColumnType("BIT")
                .HasDefaultValue(false)
                .IsRequired(false);
        }
    }
}