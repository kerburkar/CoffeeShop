using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity
{
    public class CoffeeCategory
    {
        public int Id { get; set; }

        public string CoffeeCategoryName { get; set; }

        public virtual List<Coffee> Coffees { get; set; }
    }
}
