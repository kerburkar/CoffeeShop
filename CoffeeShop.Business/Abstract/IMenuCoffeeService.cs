using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Business.Abstract
{
    public interface IMenuCoffeeService
    {
        IList<MenuCoffee> GetMenuCoffees();
        MenuCoffee GetMenuCoffee(int id);
    }
}
