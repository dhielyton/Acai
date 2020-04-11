using Acai.Domain.Acompanhamento;
using Acai.Domain.Pedido;
using Acai.Domain.Produto;
using Acai.Domain.Sabor;
using Acai.Domain.Tamanho;
using Acai.Infrastructure.EntityConfiguration;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure
{
    public class AcaiContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Acompanhamento> Acompnhamentos { get; set; }
        public DbSet<Sabor> Sabores { get; set; }
        public DbSet<Domain.Tamanho.Tamanho> Tamanhos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProdutoTypeConfiguration());
            modelBuilder.ApplyConfiguration(new AcompanhamentoTypeConfiguration());
            modelBuilder.ApplyConfiguration(new SaborTypeConfiguration());
            modelBuilder.ApplyConfiguration(new TamanhoTypeConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoTypeConfiguration());

        }
    }
}
