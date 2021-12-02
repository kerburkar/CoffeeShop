using CoffeeShop.DataAccess.Abstract;
using CoffeeShop.DataAccess.Concrete.EntityFramework.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DataAccess.Concrete.EntityFramework
{
    public class BaseRepository<T>:IBaseRepository<T> where T : class 
    {
        //ApplicationDbContext veri tabanı bağlantısı için inject edildi. (DependencyInjection)
        private readonly ApplicationDbContext _context;
        public BaseRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public T Get(Expression<Func<T, bool>> predicate)
        {

            return _context.Set<T>().AsNoTracking().SingleOrDefault(predicate);

        }

        public T Get(Expression<Func<T, bool>> predicate, params string[] nav)
        {
            var query = _context.Set<T>().AsQueryable();
            return nav.Aggregate(query, (current, n) => current.Include(n)).SingleOrDefault(predicate);

        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null)
        {

            return predicate == null ? _context.Set<T>().AsNoTracking() : _context.Set<T>().Where(predicate).AsNoTracking();

        }

        public IQueryable<T> GetAll(params string[] nav)
        {

            var query = _context.Set<T>().AsQueryable();
            return nav.Aggregate(query, (current, n) => current.Include(n));
        }

        public IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null, params string[] nav)
        {

            var query = predicate == null ? _context.Set<T>() : _context.Set<T>().Where(predicate);
            return nav.Aggregate(query, (current, n) => current.Include(n)).AsNoTracking();

        }

        public void Add(T entity)
        {

            var addedEntityEntry = _context.Entry(entity);
            addedEntityEntry.State = EntityState.Added;
            _context.SaveChanges();

        }

        public void Delete(T entity, int id)
        {
            var existingEntity = _context.Set<T>().Find(id);
            _context.Remove(existingEntity);
            _context.SaveChanges();

        }

        public void Update(T entity, int id)
        {
            var existingEntity = _context.Set<T>().Find(id);

            _context.Entry(existingEntity).CurrentValues.SetValues(entity);
            _context.SaveChanges();


        }
    }
}
}
