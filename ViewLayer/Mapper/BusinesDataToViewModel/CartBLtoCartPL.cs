using AutoMapper;
using BusinesLogicLayer.Model;
using DataAccessLayer.Model;
using KotelSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KotelSite.Mapper.BusinesDataToViewModel
{
    public class CartBLtoCartPL : Profile
    {
        public CartBLtoCartPL() 
        {
            CreateMap<CartBL, CartPL>().ForMember(c => c.Count, s => s.MapFrom(d => d.Count)).ReverseMap();
        }
    }
}
