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
    public class CoffeePlaceService : ICoffeePlaceService
    {
        private readonly ICoffeePlaceRepository _coffeePlaceRepository;
        public CoffeePlaceService(ICoffeePlaceRepository coffeePlaceRepository)
        {
            _coffeePlaceRepository = coffeePlaceRepository;
        }
        public IList<CoffeePlace> GetCoffeePlaces()
        {
            return _coffeePlaceRepository.GetAll().ToList();

        }

        public CoffeePlace GetCoffeePlace(int id)
        {
            return _coffeePlaceRepository.Get(q => q.Id == id);
        }
    }
}
