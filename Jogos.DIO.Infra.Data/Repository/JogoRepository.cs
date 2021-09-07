using Microsoft.EntityFrameworkCore;
using Jogos.DIO.Domain.Entities;
using Jogos.DIO.Domain.Interfaces.Repositories;
using Jogos.DIO.Infra.Data.Context;

namespace Jogos.DIO.Infra.Data.Repository
{
    public sealed class JogoRepository : RepositoryBase<JogoEntity, JogoContext>, IJogoRepository
    {
        public JogoRepository(JogoContext context) : base(context)
        {
        }
    }
}
