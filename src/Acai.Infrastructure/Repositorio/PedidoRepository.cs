using Acai.Domain.Pedido;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure.Repositorio
{
    public class PedidoRepository : Repository<Pedido>, IPedidoRepository
    {
        public PedidoRepository(DbSet<Pedido> dbSet, DbContext context) : base(dbSet, context)
        {
        }
    }
}
