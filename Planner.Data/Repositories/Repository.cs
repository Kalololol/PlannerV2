using Microsoft.EntityFrameworkCore;
using Planner.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Planner.Data
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity
    {
        private readonly ApplicationDbContext _context;
        private DbSet<TEntity> entities;

        public Repository(ApplicationDbContext context)
        {
            this._context = context;
            this.entities = context.Set<TEntity>();
        }

        public void Add(TEntity entity)
        {
            entities.Add(entity);
            SaveChanges();
        }

        public void Update(TEntity entity)
        {
            entities.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            SaveChanges();
        }

        public TEntity GetById(int id)
        {
            return entities.SingleOrDefault(e => e.Id == id);
        }

        public IQueryable<TEntity> GetAll()
        {
            return entities;
        }

        public IQueryable<TEntity> Find(Expression<Func<TEntity, bool>> predicate)
        {
            return entities.Where(predicate);
        }

        public void Delete(TEntity entity)
        {

            entities.Remove(entity);
            SaveChanges();
        }

        public void SaveChanges()
        {
            _context.SaveChanges();
        }
    }
}
