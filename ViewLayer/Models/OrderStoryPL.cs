using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Models
{
    public class OrderStoryPL
    {
        public int Id { get; set; }

        public int UserId { get; set; }

        public string ListOfProducts { get; set; }

        public string ListOfProductsId { get; set; }

        public double Money { get; set; }

        public DateTime OrderTime { get; set; }
    }
}
