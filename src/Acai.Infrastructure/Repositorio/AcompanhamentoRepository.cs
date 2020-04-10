using Acai.Domain.Acompanhamento;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acai.Infrastructure.Repositorio
{
    public class AcompanhamentoRepository : Repository<Acompanhamento>, IAcompanhamentoRepository
    {
        public AcompanhamentoRepository(DbSet<Acompanhamento> dbSet, DbContext context) : base(dbSet, context)
        {
        }

        
    }
}
