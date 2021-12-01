using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity
{
    public class Menu
    {
        public int Id { get; set; }

        public string MenuName { get; set; }

        public int CoffeePlaceId { get; set; }

        public CoffeePlace CoffeePlace { get; set; }

        public virtual List<MenuCoffee> MenuCoffee { get; set; }
    }
}
