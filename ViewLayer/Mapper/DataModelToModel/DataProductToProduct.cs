using AutoMapper;
using DataAccessLayer.DataModel;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotelSite.Mapper.DataModelToModel
{
    public class DataProductToProduct : Profile
    {
        public DataProductToProduct() 
        {
            CreateMap<DataProduct, Product>().ForMember(c => c.Articul, s => s.MapFrom(d => d.Articul)).ReverseMap();
        }
    }
}
