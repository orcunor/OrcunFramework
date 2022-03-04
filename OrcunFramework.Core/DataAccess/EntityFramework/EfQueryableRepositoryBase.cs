using Microsoft.EntityFrameworkCore;
using OrcunFramework.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrcunFramework.Core.DataAccess.EntityFramework
{
    public class EfQueryableRepositoryBase<T> : IQueryableRepository<T> where T : class, IEntity, new()
    {
        private DbContext _context;
        private DbSet<T> _entities;


        public EfQueryableRepositoryBase(DbContext context)
        {
            _context = context;
        }

        public IQueryable<T> Table => this.Entities;

        protected virtual DbSet<T> Entities 
        {
            get
            {
               return InitializeTable();
            }
        }

        private DbSet<T> InitializeTable()
        {
            if (_entities == null) 
                _entities = _context.Set<T>();

            return _entities;
        }
    }
}
