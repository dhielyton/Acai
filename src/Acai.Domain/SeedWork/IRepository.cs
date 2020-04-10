using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acai.Domain.SeedWork
{
    public interface IRepository<T> where T : Entity
    {

        T Incluir(T entity);
        T Editar(T entity);
        void Excluir(T Entity);
        Task<T> ObterPorId(int id);
        
    }
}
