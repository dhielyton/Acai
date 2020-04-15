using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Domain.Produto
{
    public interface IAdicionaisDecorator: IProductComponente
    {
         IProductComponente Produto { get; set; }
    }
}
