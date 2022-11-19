using AutoMapper;
using BusinesLogicLayer.Model;
using DataAccessLayer.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Mapper.BusinesDataToDataModel
{
    public class UserRequestBLtoDataUserRequest : Profile
    {
        public UserRequestBLtoDataUserRequest() 
        {
            CreateMap<UserRequestBL, DataUserRequest>().ReverseMap();
        }
    }
}
