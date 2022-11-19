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
    public class OrderStoryBLtoOrderStoryPL : Profile
    {
        public OrderStoryBLtoOrderStoryPL() 
        {
            CreateMap<OrderStoryBL, OrderStoryPL>().ForMember(c => c.OrderTime, s => s.MapFrom(d => DateTime.Now)).ReverseMap();
        }
    }
}
