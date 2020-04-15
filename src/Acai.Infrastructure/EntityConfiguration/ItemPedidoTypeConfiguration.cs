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
            builder.HasOne(x => x.Produto).WithMany().HasForeignKey(x => x.ProdutoId);
            builder.Property(x => x.ProdutoId).HasColumnName("id_produto");
            builder.HasOne(x => x.Tamanho).WithMany().HasForeignKey(x => x.TamanhoId);
            builder.Property(x => x.TamanhoId).HasColumnName("id_tamanho");
            builder.HasOne(x => x.Sabor).WithMany().HasForeignKey(x => x.TamanhoId);
            builder.Property(x => x.SaborId).HasColumnName("id_sabor");
            builder.Property(x => x.Valor).HasColumnName("valor");
            builder.Property(x => x.MinutosPreparo).HasColumnName("minutos_preparo");
            
        }
    }
}
