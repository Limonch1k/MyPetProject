using AutoMapper;
using DataAccessLayer.DataModel;
using DataAccessLayer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class UserRequestRepo
    {
        private KotelContext _context { get; set; }
        private IMapper _mapper { get; set; }

        public UserRequestRepo(IMapper mapper, KotelContext context)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task CreateRequestCall(DataUserRequest dataRequest) 
        {
            var request = _mapper.Map<UserRequestCall>(dataRequest);
            await _context.UsersRequests.AddAsync(request);
        }

        public async Task SaveAsync() 
        {
            await _context.SaveChangesAsync();
        }
     }
}
