using AutoMapper;
using BusinesLogicLayer.Model;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Mapper.BusinesDataToDataModel
{
    public class ProductClassBLtoDataProductClass : Profile
    {
        public ProductClassBLtoDataProductClass() 
        {
            CreateMap<ProductClassBL, DataProductClass>().ForMember(c => c.NameOfProduct, s => s.MapFrom(c => c.NameOfProduct)).ReverseMap();
        }
    }
}
