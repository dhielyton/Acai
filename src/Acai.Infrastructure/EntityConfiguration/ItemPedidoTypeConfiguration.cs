using Acai.Domain.Pedido;
using Acai.Domain.Produto;
using Acai.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure.EntityConfiguration
{
    public class ItemPedidoTypeConfiguration : IEntityTypeConfiguration<ItemPedido>
    {
        public void Configure(EntityTypeBuilder<ItemPedido> builder)
        {
            builder.ToTable("item_pedido");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_item_pedido");
            builder.HasOne(x => x.Produto).WithMany().HasForeignKey(x => x.Id);
            builder.Property(x => x.Valor).HasColumnName("valor");
            builder.Property(x => x.MinutosPreparo).HasColumnName("minutos_preparo");
            
        }
    }
}
