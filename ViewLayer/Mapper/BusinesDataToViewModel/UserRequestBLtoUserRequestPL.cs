using AutoMapper;
using BusinesLogicLayer.Model;
using DataAccessLayer.Model;
using KotelSite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Mapper.BusinesDataToViewModel
{
    public class UserRequestBLtoUserRequestPL : Profile
    {
        public UserRequestBLtoUserRequestPL()
        {
            CreateMap<UserRequestBL, RequestCallPL>().ReverseMap();
        }
    }
}
