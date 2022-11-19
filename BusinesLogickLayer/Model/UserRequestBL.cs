using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.Model
{
    public class UserRequestBL
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string AddInformation { get; set; }

        public bool ConfirmPolice { get; set; }
    }
}
