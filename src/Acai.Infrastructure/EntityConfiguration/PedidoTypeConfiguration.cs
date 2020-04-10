using Acai.Domain.Pedido;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure.EntityConfiguration
{
    public class PedidoTypeConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.ToTable("pedido");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_pedido");
            builder.Property(x => x.ValorTotal).HasColumnName("valor_total");
            builder.Property(x => x.MinutosPreparo).HasColumnName("minutos_prepapro");
        }
    }
}
