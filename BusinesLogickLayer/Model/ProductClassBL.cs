using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.Model
{
    public class ProductClassBL
    {
        public int Id { get; set; }

        public string NameOfProduct { get; set; }

        public string LinkToImage { get; set; }
    }
}
