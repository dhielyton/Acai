using Acai.Domain.Tamanho;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acai.Infrastructure.Repositorio
{
    public class TamanhoRepository : Repository<Tamanho>, ITamanhoRepository
    {
        public TamanhoRepository(DbSet<Tamanho> dbSet, DbContext context) : base(dbSet, context)
        {
        }

        public async Task<ICollection<Tamanho>> ObterPorProduto(int idProduto)
        {
            return await _DbSet.Where(x => x.ProdutoId == idProduto).ToListAsync()
        }
    }
}
