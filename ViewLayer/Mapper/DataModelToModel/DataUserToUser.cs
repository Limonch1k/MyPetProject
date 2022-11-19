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
    public class DataUserToUser : Profile
    {
        public DataUserToUser() 
        {
            CreateMap<DataUser, User>().ForMember(c => c.CartId, s => s.MapFrom(d => d.CartId));
        }
    }
}
