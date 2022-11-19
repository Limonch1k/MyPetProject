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
    public class CouponBLtoCouponPL : Profile
    {
        public CouponBLtoCouponPL() 
        {
            CreateMap<CouponBL, CouponPL>().ForMember(c => c.Sale, s => s.MapFrom(d => d.Sale));
        }
    }
}
