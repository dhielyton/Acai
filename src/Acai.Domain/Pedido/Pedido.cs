using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Pedido
{
    public class Pedido : Entity, ITempoPreparo
    {
        public DateTime Data { get; set; }
        public ICollection<ItemPedido> ItemPedidos { get; private set; }
        public decimal ValorTotal { get; set; }
        public int MinutosPreparo { get;  set; }

        public void AddItem(ItemPedido item)
        {
            ItemPedidos = ItemPedidos ?? new List<ItemPedido>();
            ItemPedidos.Add(item);
            AddMinutosPreparo(item as ITempoPreparo);

        }

        private void AddMinutosPreparo(ITempoPreparo item)
        {
            if (item != null)
                MinutosPreparo += item.MinutosPreparo;
        }

        private void RemoveMinutosPreparo(ITempoPreparo item)
        {
            if (item != null)
                MinutosPreparo -= item.MinutosPreparo;
        }


    }
}
