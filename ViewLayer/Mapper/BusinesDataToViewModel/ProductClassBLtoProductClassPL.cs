using AutoMapper;
using BusinesLogicLayer.Model;
using KotelSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Mapper.BusinesDataToViewModel
{
    public class ProductClassBLtoProductClassPL : Profile
    {
        public ProductClassBLtoProductClassPL()
        {
            CreateMap<ProductClassBL, ProductClassPL>().ForMember(c => c.NameOfProduct, s => s.MapFrom(c => c.NameOfProduct)).ReverseMap();
        }
    }
}
