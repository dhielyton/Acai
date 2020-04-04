using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Produto
{
    public class Produto : Entity, IProductComponente
    {
        public Produto(string descricao)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentNullException("O argumento descrição não pode ser vazio ou null");

            Descricao = descricao;
        }

        public string Descricao { get; set; }

        public static Produto Create(string descricao)
        {
            return new Produto(descricao);
        }

        public string GetDescricao()
        {
            return Descricao;
        }

        public int GetMinutosPreparo()
        {
            return 0;
        }

        public decimal GetPreco()
        {
            return 0.00M;
        }
    }
}
