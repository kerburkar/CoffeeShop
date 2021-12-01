using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity
{
    public class Region
    {
       
        public int Id { get; set; }
        public string RegionName { get; set; }

        //şehir ile bölgeler arasında foreinkey oluşturuldu.
        public int CityId { get; set; }

        public City City { get; set; }

        public List<CoffeePlace> CoffeePlaces { get; set; }



    }
}
