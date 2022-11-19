using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.Model
{
    public class CartBL
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public int UserId { get; set; }

        public string ProductsId { get; set; }
    }
}
