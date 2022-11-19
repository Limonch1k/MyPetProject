using AutoMapper;
using DataAccessLayer.DataModel;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Mapper.DataModelToModel
{
    public class DataUserRequestToUserRequest : Profile
    {
        public DataUserRequestToUserRequest() 
        {
            CreateMap<DataUserRequest, UserRequestCall>().ReverseMap();
        }
    }
}
