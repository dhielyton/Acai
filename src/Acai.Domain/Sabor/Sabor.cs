using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Sabor
{
    public class Sabor : Entity, ITempoPreparo
    {
        public Sabor(string descricao, int minutos = 0)
        {
            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentNullException("O argumento descrição não pode ser vazio ou nulo");
            Descricao = descricao;
            MinutosPreparo = minutos;
        }

        public string Descricao { get; set; }
        public int MinutosPreparo { get; set; }
        public static Sabor Create(string descricao, int minutosPreparacao = 0)
        {
            return new Sabor(descricao, minutosPreparacao);
        }
    }
}
