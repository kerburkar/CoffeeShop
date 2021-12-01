using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity
{
    public class City
    {
        //şehirler arasında uniqueliğin sağlanması için primarykey tanımlandı.
        public int Id { get; set; }
        public string CityName { get; set; }

        //şehirlerin bölgeleri list olarak tanımlandı.
        public List<Region> Regions { get; set; }


    }
}
