using CoffeeShop.Business.Abstract;
using CoffeeShop.DataAccess.Abstract;
using CoffeeShop.DataAccess.Concrete.EntityFramework;
using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Concrete
{
    public class MenuCoffeeService : IMenuCoffeeService
    {
        private readonly IMenuCoffeeRepository _menuCoffeeRepository;

        public MenuCoffeeService(IMenuCoffeeRepository menuCoffeeRepository)
        {
            _menuCoffeeRepository = menuCoffeeRepository;
        }
        public IList<MenuCoffee> GetMenuCoffees()
        {
            return _menuCoffeeRepository.GetAll().ToList();

        }

        public MenuCoffee GetMenuCoffee(int id)
        {
            return _menuCoffeeRepository.Get(q => q.Id == id);
        }
    }
}
