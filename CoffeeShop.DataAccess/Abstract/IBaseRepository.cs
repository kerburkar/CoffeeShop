using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DataAccess.Abstract
{
    //IBaseRepository, RepositoryPatern için kullanılır. 
    //Buradaki T generic sınıfları(veri tabanı sınıfları) temsil eder. Alttakiler de metot imzalarıdır. 
    public interface IBaseRepository<T>
    {
        //predicate; sorgular. örnek => CityId == 1
        //nav; T(nesne(City))'ye bağlı nesnelerin bilgilerini almak için verilir. (Include)
        T Get(Expression<Func<T, bool>> predicate);
        T Get(Expression<Func<T, bool>> predicate, params string[] nav);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null);
        IQueryable<T> GetAll(params string[] nav);
        IQueryable<T> GetAll(Expression<Func<T, bool>> predicate = null, params string[] nav);
        void Add(T entity);
        void Delete(T entity, int id);
        void Update(T entity, int id);
    }
}
