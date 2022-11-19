using AutoMapper;
using BusinesLogicLayer.Model;
using DataAccessLayer.DataModel;
using DataAccessLayer.Interface;
using DataAccessLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinesLogicLayer.Functionality
{
    public class UserServices : IDataManipulationAsync<UserBL>
    {
        private UserRepo _userRepo;

        private IMapper _mapper;

        public UserServices(UserRepo couponRepo, IMapper mapper)
        {
            _userRepo = couponRepo;
            _mapper = mapper;
        }

        public async Task CreateAsync(UserBL item)
        {
            var userData = _mapper.Map<DataUser>(item);
            await _userRepo.CreateAsync(userData);
        }

        public async Task DeleteAsync(UserBL item)
        {
            var userData = _mapper.Map<DataUser>(item);
            await _userRepo.DeleteAsync(userData);
        }

        public async Task DisposeAsync()
        {
            await _userRepo.DisposeAsync();
        }

        public async Task<UserBL> FindEntityByIdAsync(int id)
        {
            var userData = await _userRepo.FindEntityByIdAsync(id);
            var userBL = _mapper.Map<UserBL>(userData);
            return userBL;
        }

        public async Task<IEnumerable<UserBL>> GetAllAsync()
        {
            var usersData = await _userRepo.GetAllAsync();
            var usersBL = _mapper.Map<IEnumerable<UserBL>>(usersData);
            return usersBL;
        }

        public async Task SaveAsync()
        {
            await _userRepo.SaveAsync();
        }

        public async Task UpdateAsync(int id, UserBL item)
        {
            var userData = _mapper.Map<DataUser>(item);
            await _userRepo.UpdateAsync(id, userData);
        }
    }
}
