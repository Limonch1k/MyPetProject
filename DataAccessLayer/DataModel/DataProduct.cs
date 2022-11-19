using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.DataModel
{
    public class DataProduct
    {
        public int Id { get; set; }
        public string LinkToImage { get; set; }
        public string Class { get; set; }
        public string SubClass { get; set; }
        public string Brand { get; set; }
        public bool ExistOnRepository { get; set; }
        public int Articul { get; set; }
        public double Cost { get; set; }
        public string NameOfProduct { get; set; }
        public string Description { get; set; }
    }
}
