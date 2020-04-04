using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Produto
{
    public interface IProductComponente
    {
        string GetDescricao();
        decimal GetPreco();
        int GetMinutosPreparo();
    }
}
