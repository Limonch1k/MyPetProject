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
    public class CouponBLtoDataCoupon : Profile
    {
        public CouponBLtoDataCoupon() 
        {
            CreateMap<CouponBL, DataCoupon>().ForMember(c => c.ProductsId, s => s.MapFrom( d => d.ProductsId)).ReverseMap();
        }
    }
}
