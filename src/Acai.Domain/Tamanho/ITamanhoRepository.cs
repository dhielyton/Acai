using Acai.Domain.SeedWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acai.Domain.Tamanho
{
    public interface ITamanhoRepository: IRepository<Tamanho>
    {
        Task<ICollection<Tamanho>> ObterPorProduto(int idProduto);
    }
}
