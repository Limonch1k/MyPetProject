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
    public class UserBLtoDataUser : Profile
    {
        public UserBLtoDataUser() 
        {
            CreateMap<UserBL, DataUser>().ForMember(c => c.Role, s => s.MapFrom( d => d.Role));
        }
    }
}
