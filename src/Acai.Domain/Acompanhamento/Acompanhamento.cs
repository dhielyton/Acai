using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Acompanhamento
{
    public class Acompanhamento : Produto.Produto, IPreco, ITempoPreparo
    {
        public Acompanhamento(string descricao, decimal preco , int minutosPreparo = 0) : base(descricao)
        {
            Preco = preco;
            MinutosPreparo = minutosPreparo;
        }

        public decimal Preco { get; set; }
        public int MinutosPreparo { get ; set ; }

        public static Acompanhamento Create(string descricao, decimal preco = 0.00M, int minutosPreparo = 0)
        {
            return new Acompanhamento(descricao, preco, minutosPreparo);
        }
    }
}
