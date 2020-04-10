using Acai.Domain.Sabor;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acai.Infrastructure.Repositorio
{
    public class SaborRepository : Repository<Sabor>, ISaborRepository
    {
        public SaborRepository(DbSet<Sabor> dbSet, DbContext context) : base(dbSet, context)
        {
        }

        public async Task<ICollection<Sabor>> ObterPorProduto(int idProduto)
        {
            return await _DbSet.Where(x => x.ProdutoId == idProduto).ToListAsync();
        }
    }
}
