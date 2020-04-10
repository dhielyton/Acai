using Acai.Domain.Produto;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure.Repositorio
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(DbSet<Produto> dbSet, DbContext context) : base(dbSet, context)
        {
        }
    }
}
