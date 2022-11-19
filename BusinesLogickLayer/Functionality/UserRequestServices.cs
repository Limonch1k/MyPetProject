using AutoMapper;
using BusinesLogicLayer.Model;
using DataAccessLayer.DataModel;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.Functionality
{
    public class UserRequestServices
    {
        private IMapper _mapper { get; set; }
        private UserRequestRepo _userRequest { get; set; }

        public UserRequestServices(IMapper mapper, UserRequestRepo userRequest)
        {
            _mapper = mapper;
            _userRequest = userRequest;
        }

        public async Task CreateRequestCall(UserRequestBL requestBL) 
        {
            var dataRequest = _mapper.Map<DataUserRequest>(requestBL);
            await _userRequest.CreateRequestCall(dataRequest);
            await _userRequest.SaveAsync();
        }
     }
}
