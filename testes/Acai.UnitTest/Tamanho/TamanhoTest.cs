using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Acai.Domain.Produto;

namespace Acai.UnitTest.Tamanho
{

    public class TamanhoTest
    {
        private IProductComponente produto;
        public TamanhoTest()
        {
            produto = Domain.Produto.Produto.Create("Açai");
            
        }
        [Fact]
        public void CriarTamanhoComSucessoSemTempoAdicional()
        {
            produto = Domain.Sabor.Sabor.Create(produto, "Morango");
            var tamanho = Domain.Tamanho.Tamanho.Create(produto, "Pequeno", 10.00M, 5);
            tamanho.Should().NotBeNull();
            tamanho.Produto.Should().NotBeNull();
            tamanho.GetDescricao().Should().NotBeNullOrEmpty();
            tamanho.GetDescricao().Should().Be("Açai Morango Pequeno");
            tamanho.GetPreco().Should().Be(10.00M);
            tamanho.GetMinutosPreparo().Should().Be(5);
        }

        [Fact]
        public void CriarTamanhoComSucessoComTempoAdicional()
        {
            produto = Domain.Sabor.Sabor.Create(produto, "Kwi", 5);
            var tamanho = Domain.Tamanho.Tamanho.Create(produto, "Pequeno", 10.00M, 5);
            tamanho.Should().NotBeNull();
            tamanho.Produto.Should().NotBeNull();
            tamanho.GetDescricao().Should().NotBeNullOrEmpty();
            tamanho.GetDescricao().Should().Be("Açai Kwi Pequeno");
            tamanho.GetPreco().Should().Be(10.00M);
            tamanho.GetMinutosPreparo().Should().Be(10);
        }
    }
}
