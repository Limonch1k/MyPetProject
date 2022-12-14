using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    public class DataUser
    {
        public int Id { get; set; }
        public int CartId { get; set; }
        public string Login { get; set; }
        public string fullName { get; set; }
        public string Email { get; set; }

        public string Phone { get; set; }
        public string Password { get; set; }
        public bool PersonalDataHandle { get; set; }
        public string Role { get; set; }
    }
}
