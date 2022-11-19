using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    public class DataUserRequest
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AddInformation { get; set; }

        public bool ConfirmPolice { get; set; }
    }
}
