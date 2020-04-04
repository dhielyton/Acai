using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Acai.Domain.Produto;
using FluentAssertions;

namespace Acai.UnitTest.Produto
{
    
    public class ProdutoTest
    {
        [Fact]
        public void CriarProdutoComSucesso()
        {
            var produto = Acai.Domain.Produto.Produto.Create("Açai");
            produto.Should().NotBeNull();
            produto.Descricao.Should().NotBeNullOrEmpty();
        }
    }
}
