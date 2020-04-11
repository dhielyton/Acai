using Acai.Domain.Produto;
using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Pedido
{
    public class ItemPedido:Entity
    {
        public ItemPedido(IProductComponente produto)
        {
            Produto = produto;
            Valor = produto.GetPreco();
            MinutosPreparo = produto.GetMinutosPreparo();
        }

        public IProductComponente Produto { get; set; }
        public Produto.IAdicionaisDecorator Tamanho { get; set; }
        public decimal Valor { get; set; }
        public int MinutosPreparo { get; set; }
    }
}
