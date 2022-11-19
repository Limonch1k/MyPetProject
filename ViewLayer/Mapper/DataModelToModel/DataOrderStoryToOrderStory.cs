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
    public class DataOrderStoryToOrderStory : Profile
    {
        public DataOrderStoryToOrderStory() 
        {
            CreateMap<DataOrderStory, OrderStory>().ForMember(c => c.OrderTime, s => s.MapFrom(d => DateTime.Now)).ReverseMap();
        }
    }
}
