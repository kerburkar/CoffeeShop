using CoffeeShop.Business.Abstract;
using CoffeeShop.DataAccess.Abstract;
using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Concrete
{
    public class CoffeeCategoryService : ICoffeeCategoryService
    {
        private readonly ICoffeeCategoryRepository _coffeeCategoryRepository;
        public CoffeeCategoryService(ICoffeeCategoryRepository coffeeCategoryRepository)
        {
            _coffeeCategoryRepository = coffeeCategoryRepository;
        }
        public IList<CoffeeCategory> GetCoffeeCategories()
        {
            return _coffeeCategoryRepository.GetAll().ToList();

        }

        public CoffeeCategory GetCoffeeCategory(int id)
        {
            return _coffeeCategoryRepository.Get(q => q.Id == id);
        }
    }
}
