using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class ProductClass
    {
        [Key]
        public int Id { get; set; }
        
        public string NameOfProduct { get; set; }

        public string LinkToImage { get; set; }

        public List<Product> Products { get; set; }
    }
}
