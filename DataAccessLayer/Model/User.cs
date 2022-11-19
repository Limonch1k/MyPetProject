using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        public int CartId { get; set;}

        [Required]
        [MaxLength(30)]
        [MinLength(3)]
        public string Login { get; set;}

        [Required]
        [MaxLength(100)]
        [MinLength(10)]
        public string FullName { get; set; }

        [Required]
        [RegularExpression(@"/^\w+@\S+\.\S+$/")]
        public string Email { get; set; }

        [Required]
        public string Phone { get; set; }

        [Required]
        [MinLength(5)]
        public string Password { get; set; }

        [Required]
        public bool PersonalDataHandle { get; set; }

        [Required]
        public string Role { get; set; }

        [ForeignKey("CartId")]
        public Cart Cart{ get; set; }

        public List<OrderStory> OrderStories { get; set; }
    }
}
