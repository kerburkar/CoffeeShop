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
    public class CoffeeService : ICoffeeService
    {

        private readonly ICoffeeRepository _coffeeRepository;
        public CoffeeService(ICoffeeRepository coffeeRepository)
        {
            _coffeeRepository = coffeeRepository;
        }
        public IList<Coffee> GetCoffees()
        {
            return _coffeeRepository.GetAll().ToList();

        }

        public Coffee GetCoffee(int id)
        {
            return _coffeeRepository.Get(q => q.Id == id);
        }
}