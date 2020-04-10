using Acai.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Acai.Infrastructure.Repositorio
{
    public class Repository<T> : IRepository<T> where T:Entity
    {
        protected DbSet<T> _DbSet;
        protected DbContext _context;

        public Repository(DbSet<T> dbSet, DbContext context)
        {
            _DbSet = dbSet;
            _context = context;
        }

        public T Editar(T entity)
        {
            return _DbSet.Update(entity).Entity;
        }

        public void Excluir(T entity)
        {
            _DbSet.Remove(entity);
            _context.SaveChanges();
        }

        public T Incluir(T entity)
        {
            return _DbSet.Add(entity).Entity;

        }

        public Task<T> ObterPorId(int id)
        {
            return _DbSet.Where(x => x.Id == id).SingleOrDefaultAsync();
        }

       
    }
}
