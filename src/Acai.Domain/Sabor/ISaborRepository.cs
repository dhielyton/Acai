using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acai.Domain.Sabor
{
    public interface ISaborRepository: IRepository<Sabor>
    {
        Task<ICollection<Sabor>> ObterPorProduto(int idProduto);
    }
}
