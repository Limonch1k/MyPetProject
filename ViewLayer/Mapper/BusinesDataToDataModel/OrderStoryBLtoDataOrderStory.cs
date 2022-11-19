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
    public class OrderStoryBLtoDataOrderStory : Profile
    {
        public OrderStoryBLtoDataOrderStory() 
        {
            CreateMap<CouponBL, DataOrderStory>().ForMember(c => c.OrderTime, s => s.MapFrom(d => DateTime.Now)).ReverseMap();
        }
            
    }
}
