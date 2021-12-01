using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShop.Entity
{
    public class Comment
    {
        public int Id { get; set; }

        public string UserMailAdress { get; set; }

        public DateTime CommentDate { get; set; }

        public double CoffeePlaceScore { get; set; }

        public string UserComment { get; set; }

        public int CoffeePlaceId { get; set; }
        public CoffeePlace CoffeePlace { get; set; }


    }
}
