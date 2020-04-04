using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Acai.Domain.Acompanhamento;
using FluentAssertions;
namespace Acai.UnitTest.Acompanhamento
{
    public class AcompanhamentoTest
    {

        [Fact]
        public void CriarAcompanhamentoComSucesso()
        {
            var acompanhamento = Domain.Acompanhamento.Acompanhamento.Create("Granola");
            acompanhamento.Should().NotBeNull();
            acompanhamento.Descricao.Should().NotBeNullOrEmpty();
            acompanhamento.Preco.Should().Be(0.00M);
            acompanhamento.MinutosPreparo.Should().Be(0);

        }

        [Fact]
        public void CriarAcompanhamentoComSucessoComPreco()
        {
            var acompanhamento = Domain.Acompanhamento.Acompanhamento.Create("Leite Ninho", 3.00M);
            acompanhamento.Should().NotBeNull();
            acompanhamento.Descricao.Should().NotBeNullOrEmpty();
            acompanhamento.Preco.Should().Be(3.00M);
            acompanhamento.MinutosPreparo.Should().Be(0);

        }

        [Fact]
        public void CriarAcompanhamentoComSucessoComPrecoRTempoPreparo()
        {
            var acompanhamento = Domain.Acompanhamento.Acompanhamento.Create("Paçoca", 3.00M,3);
            acompanhamento.Should().NotBeNull();
            acompanhamento.Descricao.Should().NotBeNullOrEmpty();
            acompanhamento.Preco.Should().Be(3.00M);
            acompanhamento.MinutosPreparo.Should().Be(3);

        }

    }
}
