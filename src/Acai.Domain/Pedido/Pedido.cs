using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using Acai.Domain.Produto;

namespace Acai.Domain.Pedido
{
    public class Pedido : Entity, ITempoPreparo
    {
        public Pedido()
        {

        }
        public DateTime Data { get; set; }
        public ICollection<ItemPedido> ItemPedidos { get; private set; }
        public decimal ValorTotal { get; set; }
        public int MinutosPreparo { get;  set; }

        public void AddItem(IProductComponente produto)
        {
            ItemPedidos = ItemPedidos ?? new List<ItemPedido>();
            var item = new ItemPedido(produto);
            ItemPedidos.Add(item);
            MinutosPreparo += item.MinutosPreparo;
            ValorTotal += item.Valor;

        }

        public void Processar()
        {
            Data = DateTime.Now;
            foreach(var item in ItemPedidos)
            {
                item.Processar();
            }
        }

      


    }
}
