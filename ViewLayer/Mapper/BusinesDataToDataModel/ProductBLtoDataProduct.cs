using AutoMapper;
using BusinesLogicLayer.Model;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotelSite.Mapper.BusinesDataToDataModel
{
    public class ProductBLtoDataProduct : Profile
    {
        public ProductBLtoDataProduct() 
        {
            CreateMap<ProductBL, DataProduct>().ForMember(c => c.Articul, s => s.MapFrom(d => d.Articul)).ReverseMap();
        }
    }
}
