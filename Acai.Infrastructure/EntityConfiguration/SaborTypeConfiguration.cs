using Acai.Domain.Sabor;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure.EntityConfiguration
{
    public class SaborTypeConfiguration : IEntityTypeConfiguration<Sabor>
    {
        public void Configure(EntityTypeBuilder<Sabor> builder)
        {
            builder.ToTable("sabor");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_sabor");
            builder.Property(x => x.MinutosPreparo).HasColumnName("minutos_preparo");
            builder.HasOne(x => x.Produto).WithMany().HasForeignKey(x => x.ProdutoId);
            builder.Property(x => x.ProdutoId).HasColumnName("id_produto");
        }
    }
}
