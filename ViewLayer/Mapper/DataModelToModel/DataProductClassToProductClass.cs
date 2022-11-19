using AutoMapper;
using DataAccessLayer.DataModel;
using DataAccessLayer.Model;
using KotelSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Mapper.DataModelToModel
{
    public class DataProductClassToProductClass : Profile
    {
        public DataProductClassToProductClass()
        {
            CreateMap<DataProductClass, ProductClass>().ForMember(c => c.NameOfProduct, s => s.MapFrom(c => c.NameOfProduct)).ReverseMap();
        }
    }
}
