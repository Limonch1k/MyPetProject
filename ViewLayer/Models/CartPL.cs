using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Models
{
    public class CartPL
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public int UserId { get; set; }

        public string ProductsId { get; set; }
    }
}
