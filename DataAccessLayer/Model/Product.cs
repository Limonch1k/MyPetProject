using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Product
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [ConcurrencyCheck]

        public string LinkToImage { get; set; }
        public int ProductClassId{ get; set; }

        [Required]
        [MinLength(3)]
        [ConcurrencyCheck]
        public string SubClass { get; set; }
        [Required]
        [MinLength(3)]
        [ConcurrencyCheck]
        public string Brand { get; set; }
        [Required]
        [ConcurrencyCheck]
        public bool ExistOnRepository { get; set; }
        [Required]
        [ConcurrencyCheck]
        public int Articul { get; set; }
        [Required]
        [ConcurrencyCheck]
        public double Cost { get; set; }
        [Required]
        [MinLength(3)]
        [ConcurrencyCheck]
        public string NameOfProduct { get; set; }
        public string Description { get; set; }

        [ForeignKey("ProductClassId")]
        public ProductClass ProductClass { get; set; }

    }
}
