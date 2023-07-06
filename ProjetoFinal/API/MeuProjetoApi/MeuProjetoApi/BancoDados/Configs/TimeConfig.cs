using MeuProjetoApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MeuProjetoApi.BancoDados.Configs
{
    public class TimeConfig : IEntityTypeConfiguration<Time>
    {
        public void Configure(EntityTypeBuilder<Time> builder)
        {
            builder.ToTable("Time");

            builder.HasKey(p => p.Id);
            builder.Property(p => p.Id).UseIdentityColumn();

            // mapeando as propriedades
            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Divisao)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.NomeTecnico)
                .IsRequired()
                .HasMaxLength(14);

            builder.Property(x => x.Divisao)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(x => x.Cidade)
                .IsRequired()
                .HasMaxLength(20);
        }
    }
}
