using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Produto
{
    public class Produto : Entity
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
    }
}
