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
    public class CartBLtoDataCart : Profile
    {
        public CartBLtoDataCart() 
        {
            CreateMap<CartBL, DataCart>()
                .ForMember(c => c.Count, d => d.MapFrom(src => src.Count)).ReverseMap();
        }
    }
}
