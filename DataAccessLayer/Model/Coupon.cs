using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Coupon
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double Sale { get; set; }
        public string ProductsId { get; set; }

    }
}
