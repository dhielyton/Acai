using Acai.Domain.Acompanhamento;
using Acai.Domain.Produto;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure.EntityConfiguration
{
    public class AcompanhamentoTypeConfiguration : IEntityTypeConfiguration<Acompanhamento>
    {
        public void Configure(EntityTypeBuilder<Acompanhamento> builder)
        {
            builder.HasBaseType<Produto>();
            builder.Property(x => x.Preco).HasColumnName("preco");
            builder.Property(x => x.MinutosPreparo).HasColumnName("minutos_preparo");
        }
    }
}
