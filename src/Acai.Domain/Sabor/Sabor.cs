using Acai.Domain.Produto;
using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Sabor
{
    public class Sabor : Entity, ITempoPreparo, IAdicionaisDecorator
    {
        public Sabor(IProductComponente produto, string descricao, int minutos = 0)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentNullException("O argumento descrição não pode ser vazio ou nulo");
            Produto = produto;
            Descricao = descricao;
            MinutosPreparo = minutos;
        }

        public IProductComponente Produto { get; set; }
        public int MyProperty { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public int MinutosPreparo { get; set; }
        public static Sabor Create(IProductComponente produto, string descricao, int minutosPreparacao = 0)
        {
            return new Sabor(produto, descricao, minutosPreparacao);
        }

        public string GetDescricao()
        {
            return $"{Produto.GetDescricao()} {Descricao}";
        }

        public int GetMinutosPreparo()
        {
            return MinutosPreparo + Produto.GetMinutosPreparo();
        }

        public decimal GetPreco()
        {
            return 0.00M + Produto.GetPreco();
        }
    }
}
