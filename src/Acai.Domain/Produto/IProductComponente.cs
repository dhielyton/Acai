﻿using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Produto
{
    public interface IProductComponente: IEntity
    {
        
        string GetDescricao();
        decimal GetPreco();
        int GetMinutosPreparo();
    }
}
