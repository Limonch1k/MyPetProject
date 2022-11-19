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
    public class DataCartToCart : Profile
    {
        public DataCartToCart() 
        {
            CreateMap<DataCart, Cart>().ForMember(c => c.Count, s => s.MapFrom(d => d.Count)).ReverseMap();
        }
    }
}
