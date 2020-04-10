using Acai.Domain.SeedWork;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Acai.Infrastructure.Repositorio
{
    public class Repository<T> where T :Entity, IRepository<T>
    {
        private DbSet<T> _DbSet;

        public Repository(DbSet<T> dbSet)
        {
            _DbSet = dbSet;
        }
    }
}
