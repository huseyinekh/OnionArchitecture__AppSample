using Microsoft.EntityFrameworkCore;
using OnionArchitecture.Data;
using OnionArchitecture.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionArchitecture.Service
{
    public class Repository<TEntity, TKey> : IRepository<TEntity, TKey>
        where TEntity : BaseEntity<TKey>
        where TKey : IEquatable<TKey>
    {

        private readonly AppDbContext _context;
         DbSet<TEntity> _entity;

        public Repository(AppDbContext context)
        {
            _context = context;
            _entity=_context.Set<TEntity>();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _entity.AsEnumerable();
        }

        public TEntity? GetById(TKey id)
        {
            return _entity.Find(id);
        } 
    }
}
