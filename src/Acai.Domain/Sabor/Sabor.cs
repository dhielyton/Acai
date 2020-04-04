using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Sabor
{
    public class Sabor : Entity, ITempoPreparo
    {
        public Sabor(Produto.Produto produto, string descricao, int minutos = 0)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentNullException("O argumento descrição não pode ser vazio ou nulo");
            Descricao = descricao;
            MinutosPreparo = minutos;
        }

        public Produto.Produto Produto { get; set; }
        public int MyProperty { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public int MinutosPreparo { get; set; }
        public static Sabor Create(Produto.Produto produto, string descricao, int minutosPreparacao = 0)
        {
            return new Sabor(produto, descricao, minutosPreparacao);
        }
    }
}
