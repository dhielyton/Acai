using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
namespace Acai.UnitTest.Tamanho
{

    public class TamanhoTest
    {
        private Domain.Produto.Produto produto;
        public TamanhoTest()
        {
            produto = Domain.Produto.Produto.Create("Açai");
        }
        [Fact]
        public void CriarTamanhoComSucesso()
        {
            var tamanho = Domain.Tamanho.Tamanho.Create(produto, "Pequeno", 10.00M, 5);
            tamanho.Should().NotBeNull();
            tamanho.Produto.Should().NotBeNull();
            tamanho.Produto.Descricao.Should().Be(produto.Descricao);
            tamanho.Descricao.Should().NotBeNullOrEmpty();
            tamanho.Preco.Should().Be(10.00M);
            tamanho.MinutosPreparo.Should().Be(5);
        }
    }
}
