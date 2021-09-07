using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Jogos.DIO.Domain.Entities;

namespace Jogos.DIO.Infra.Data.Mapping
{
    internal sealed class JogoMapping : IEntityTypeConfiguration<JogoEntity>
    {
        public void Configure(EntityTypeBuilder<JogoEntity> builder)
        {
            builder.ToTable("TB_JOGO");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id).HasColumnName("ID_JOGO");
            builder.Property(p => p.NmJogo).HasColumnName("NM_JOGO");
            builder.Property(p => p.NmProdutora).HasColumnName("NM_PRODUTORA");
            builder.Property(p => p.Preco).HasColumnName("PRECO");
        }
    }
}
