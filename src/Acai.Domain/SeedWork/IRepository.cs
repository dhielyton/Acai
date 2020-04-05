using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Acai.Domain.SeedWork
{
    public interface IRepository<T> where T : Entity
    {

        Task<T> Incluir(T entity);
        Task<T> Editar(T entity);
        Task Excluir(T Entity);
        Task<T> ObterPorId(int id);
        Task<ICollection<T>> ObterTodos();
    }
}
