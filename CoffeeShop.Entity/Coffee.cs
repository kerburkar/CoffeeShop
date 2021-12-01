using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity
{
    public class Coffee
    {
        public int Id { get; set; }

        public string CoffeeName { get; set; }

        public int CoffeeCategoryId { get; set; }

        public CoffeeCategory CoffeeCategory { get; set; }
    }
}
