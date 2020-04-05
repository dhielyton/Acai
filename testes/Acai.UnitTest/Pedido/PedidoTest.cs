using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Acai.Domain.Pedido;
using Acai.Domain.Produto;
using FluentAssertions;
namespace Acai.UnitTest.Pedido
{
    public class PedidoTest  
    {
        private Domain.Pedido.Pedido pedido;

        [Fact]
        public void CriarPedidoComSucessoSemPersonalizacoes()
        {
            IProductComponente produto = Acai.Domain.Produto.Produto.Create("Açai");
            produto = Domain.Sabor.Sabor.Create(produto, "Morango");
            produto = Domain.Tamanho.Tamanho.Create(produto, "Pequeno", 10.00M, 5);
            pedido = new Domain.Pedido.Pedido();
            pedido.AddItem(produto);
            pedido.Processar();
            pedido.Should().NotBeNull();
            pedido.ItemPedidos.Count.Should().Be(1);
            

            
        }

    }
}
