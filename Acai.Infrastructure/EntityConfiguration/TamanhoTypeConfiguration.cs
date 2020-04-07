using Acai.Domain.Tamanho;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure.EntityConfiguration
{
    public class TamanhoTypeConfiguration : IEntityTypeConfiguration<Tamanho>
    {
        public void Configure(EntityTypeBuilder<Tamanho> builder)
        {
            builder.ToTable("tamanho");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("id_tamanho");
            builder.Property(x => x.Descricao).HasColumnName("descricao");
            builder.Property(x => x.Preco).HasColumnName("preco");
            builder.Property(x => x.MinutosPreparo).HasColumnName("minutos_preparo");
            builder.HasOne(x => x.Produto).WithMany().HasForeignKey(x => x.ProdutoId);
            builder.Property(x => x.ProdutoId).HasColumnName("id_produto");
        }
    }
}
