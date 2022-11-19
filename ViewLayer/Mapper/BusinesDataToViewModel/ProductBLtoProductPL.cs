using AutoMapper;
using BusinesLogicLayer.Model;
using KotelSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotelSite.Mapper.BusinesDataToViewModel
{
    public class ProductBLtoProductPL : Profile
    {
        public ProductBLtoProductPL() 
        {
            CreateMap<ProductBL, ProductPL>().ForMember(c => c.Articul, s => s.MapFrom(d => d.Articul)).ReverseMap();
        }
    }
}
