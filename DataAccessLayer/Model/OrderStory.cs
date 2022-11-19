using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class OrderStory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        
        
        public string ListOfProduct { get; set; }

        public string ListOfProductsId { get; set; } 

        [Required]
        public double Money { get; set; }
        [Required]
        public DateTime OrderTime { get; set; }

        [ForeignKey("UserId")]
        public User User { get; set; }

        
    }
}
