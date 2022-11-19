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
    public class DataCouponToCoupon : Profile
    {
        public DataCouponToCoupon() 
        {
            CreateMap<DataCoupon, Coupon>().ForMember(c => c.Sale, s => s.MapFrom(d => d.Sale));
        }
    }
}
