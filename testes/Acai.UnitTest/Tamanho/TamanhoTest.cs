using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
namespace Acai.UnitTest.Tamanho
{

    public class TamanhoTest
    {
        [Fact]
        public void CriarTamanhoComSucesso()
        {
            var tamanho = Domain.Tamanho.Tamanho.Create("Pequeno",10.00M,5);
            tamanho.Should().NotBeNull();
            tamanho.Descricao.Should().NotBeNullOrEmpty();
            tamanho.Preco.Should().Be(10.00M);
            tamanho.MinutosPreparo.Should().Be(5);
        }
    }
}
