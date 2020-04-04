﻿using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using Acai.Domain.Produto;
namespace Acai.Domain.Tamanho
{
    public class Tamanho : Entity, IPreco, ITempoPreparo
    {

        public Tamanho(Produto.Produto produto, string descricao, decimal preco, int minutosPreparo)
        {
            if (produto == null)
                throw new ArgumentNullException("O produto não pode ser nulo");

            if (string.IsNullOrEmpty(descricao))
                throw new ArgumentException("A descrição não pode ser vazia ou nula");
            Produto = produto;
            Descricao = descricao;
            Preco = preco;
            MinutosPreparo = minutosPreparo;
        }
        public Produto.Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }
        public int MinutosPreparo { get; set; }

        public static Tamanho Create(Produto.Produto produto, string descricao, decimal preco, int minutos)
        {
            return new Tamanho(produto, descricao, preco, minutos);
        }
    }
}
