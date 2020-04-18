using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Acai.Domain.Pedido;
using Acai.Domain.Produto;
using FluentAssertions;
using System.Linq;

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
            var item = pedido.ItemPedidos.FirstOrDefault();
            item.Should().NotBeNull();
            pedido.ValorTotal.Should().Be(item.ProdutoComponente.GetPreco());
            pedido.MinutosPreparo.Should().Be(item.ProdutoComponente.GetMinutosPreparo());
        }

        [Fact]
        public void CriarpedidoComSucessoComPersonalizacoes()
        {
            IProductComponente produto = Acai.Domain.Produto.Produto.Create("Açai");
            produto = Domain.Sabor.Sabor.Create(produto, "Morango");
            produto = Domain.Tamanho.Tamanho.Create(produto, "Pequeno", 10.00M, 5);
            pedido = new Domain.Pedido.Pedido();
            pedido.AddItem(produto);
            var acompanhamento = Domain.Acompanhamento.Acompanhamento.Create("Leite Ninho", 3);
            pedido.AddItem(acompanhamento);
            acompanhamento = Domain.Acompanhamento.Acompanhamento.Create("Granola");
            pedido.AddItem(acompanhamento);
            acompanhamento = Domain.Acompanhamento.Acompanhamento.Create("Paçoca", 3.00M, 3);
            pedido.AddItem(acompanhamento);
            pedido.Processar();
            pedido.Should().NotBeNull();
            pedido.ItemPedidos.Count.Should().Be(4);
            pedido.ValorTotal.Should().Be(pedido.ItemPedidos.Sum(x => x.ProdutoComponente.GetPreco()));
            pedido.MinutosPreparo.Should().Be(pedido.ItemPedidos.Sum(x => x.ProdutoComponente.GetMinutosPreparo()));

        }

        

    }
}
