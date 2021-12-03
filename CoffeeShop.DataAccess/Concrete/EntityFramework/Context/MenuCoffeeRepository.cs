using CoffeeShop.DataAccess.Abstract;
using CoffeeShop.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.DataAccess.Concrete.EntityFramework.Context
{
    public class MenuCoffeeRepository : BaseRepository<MenuCoffee>, IMenuCoffeeRepository
    {
        public MenuCoffeeRepository(ApplicationDbContext context) : base(context)
        {

        }
    }
}
