using Microsoft.EntityFrameworkCore;
using Jogos.DIO.Domain.Interfaces;
using System.Threading.Tasks;

namespace Jogos.DIO.Infra.Data.Context
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext> where TContext : DbContext
    {
        private readonly TContext _context;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }
        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
