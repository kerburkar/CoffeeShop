using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity
{
    public class CoffeePlace
    {
        public int Id { get; set; }

        public string CoffeePlaceName { get; set; }

        public string CoffeePlaceAddress { get; set; }

        public int RegionId { get; set; }

        public Region Region { get; set; }


    }
}
