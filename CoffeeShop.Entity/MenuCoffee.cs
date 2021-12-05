using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity
{
    public class MenuCoffee
    {
        public int MenuId { get; set; }

        public Menu Menu { get; set; }

        public int CoffeeId { get; set; }
        public Coffee Coffee { get; set; }
        public int Id { get; set; }
    }
}
