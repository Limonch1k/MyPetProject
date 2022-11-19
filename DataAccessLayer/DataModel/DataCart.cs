using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    public class DataCart
    {
        public int Id { get; set; }

        public int Count { get; set; }

        public int UserId { get; set; }

        public string ProductsId { get; set; }
    }
}
