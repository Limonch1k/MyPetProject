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
    public class UserBLtoUserPL : Profile
    {
        public UserBLtoUserPL() 
        {
            CreateMap<UserBL, UserPL>().ForMember(c => c.Role, s => s.MapFrom(d => d.Role));
        }
    }
}
