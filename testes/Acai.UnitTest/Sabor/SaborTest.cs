using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;
using Acai.Domain.Produto;

namespace Acai.UnitTest.Sabor
{


    public class SaborTest
    {
        private Domain.Produto.Produto produto;
        public SaborTest()
        {
            produto = Domain.Produto.Produto.Create("Açai");
        }
        [Fact]
        public void CriarSaborSemTempoDePreparo()
        {
            var sabor = Domain.Sabor.Sabor.Create(produto, "Morango");
            sabor.Should().NotBeNull();
            sabor.GetDescricao().Should().NotBeNullOrEmpty();
            sabor.GetDescricao().Should().Be("Açai Morango");
            sabor.GetMinutosPreparo().Should().Be(0);
        }

        [Fact]
        public void CriarSaborComTempoDePreparo()
        {
            var minutos = 5;
            var sabor = Domain.Sabor.Sabor.Create(produto,"Kwi", minutos);
            sabor.Should().NotBeNull();
            sabor.GetDescricao().Should().NotBeNullOrEmpty();
            sabor.GetDescricao().Should().Be("Açai Kwi");
            sabor.GetMinutosPreparo().Should().Be(minutos);
        }
    }
}
