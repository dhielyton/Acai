using Acai.Domain.Produto;
using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Pedido
{
    public class ItemPedido : Entity
    {
        public ItemPedido(IProductComponente produto)
        {
            ProdutoComponente = produto;
            Valor = produto.GetPreco();
            MinutosPreparo = produto.GetMinutosPreparo();
        }

        public IProductComponente ProdutoComponente { get; set; }
        public Produto.Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public Tamanho.Tamanho Tamanho { get; set; }
        public int TamanhoId { get; set; }
        public Sabor.Sabor Sabor { get; set; }
        public int SaborId { get; set; }

        public decimal Valor { get; set; }
        public int MinutosPreparo { get; set; }

        public void Processar()
        {
            Detalhar(ProdutoComponente);
        }
        public IProductComponente Detalhar(IProductComponente produtoComponent)
        {
            IAdicionaisDecorator adiconias = produtoComponent as IAdicionaisDecorator;
            if (adiconias == null)
            {
                Produto = (produtoComponent as Produto.Produto);
                return produtoComponent;
            }

            var tamanho = (produtoComponent as Tamanho.Tamanho);
            if (tamanho != null)
                Tamanho = tamanho;

            var sabor = (produtoComponent as Sabor.Sabor);
            if (sabor != null)
                Sabor = sabor;

            return Detalhar(adiconias.Produto) as Produto.Produto;

        }

    }
}
