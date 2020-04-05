using Acai.Domain.Produto;
using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Pedido
{
    public class ItemPedido:Entity
    {
        public IProductComponente Produto { get; set; }
    }
}
