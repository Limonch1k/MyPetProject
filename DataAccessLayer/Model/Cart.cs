using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class Cart
    {
        [Key]
        public int Id { get; set; }
        
        public int Count { get; set; }

        [Required]
        public int UserId { get; set; }
        public string ProductsId { get; set;}

        [ForeignKey("UserId")]
        public User User { get; set; }

    }
}
