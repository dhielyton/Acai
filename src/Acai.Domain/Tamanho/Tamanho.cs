using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Tamanho
{
    public class Tamanho : Entity, IPreco, ITempoPreparo
    {
        public Tamanho(string descricao, decimal preco, int minutosPreparo)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentException("A descrição não pode ser vazia ou nula");

            Descricao = descricao;
            Preco = preco;
            MinutosPreparo = minutosPreparo;
        }

        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int MinutosPreparo { get; set; }

        public static Tamanho Create(string descricao, decimal preco, int minutos)
        {
            return new Tamanho(descricao, preco, minutos);
        }
    }
}
