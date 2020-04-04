using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using FluentAssertions;

namespace Acai.UnitTest.Sabor
{
    public class SaborTest
    {
        [Fact]
        public void CriarSaborSemTempoDePreparo()
        {
            var sabor = Domain.Sabor.Sabor.Create("Morango");
            sabor.Should().NotBeNull();
            sabor.Descricao.Should().NotBeNullOrEmpty();
            sabor.MinutosPreparo.Should().Be(0);
        }

        [Fact]
        public void CriarSaborComTempoDePreparo()
        {
            var minutos = 5;
            var sabor = Domain.Sabor.Sabor.Create("Kwi", minutos);
            sabor.Should().NotBeNull();
            sabor.Descricao.Should().NotBeNullOrEmpty();
            sabor.MinutosPreparo.Should().Be(minutos);
        }
    }
}
