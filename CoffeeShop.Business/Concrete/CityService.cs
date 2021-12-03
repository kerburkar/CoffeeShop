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
    public class CityService : ICityService
    {

        private readonly ICityRepository _cityRepository;
        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository; 
        }
        public IList<City> GetCities()
        {
            return _cityRepository.GetAll().ToList();

        }

        public City GetCity(int id)
        {
            return _cityRepository.Get(q => q.Id == id);
        }
    }
}
