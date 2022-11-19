using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    public class DataCoupon
    {
        public int Id { get; set; }

        public double Sale { get; set; }

        public string ProductsId { get; set; }
    }
}
