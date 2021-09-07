using Microsoft.EntityFrameworkCore;
using Jogos.DIO.Domain.Entities;
using Jogos.DIO.Infra.Data.Mapping;

namespace Jogos.DIO.Infra.Data.Context
{
    public class JogoContext : DbContext
    {
        public JogoContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<JogoEntity> Jogo { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new JogoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
