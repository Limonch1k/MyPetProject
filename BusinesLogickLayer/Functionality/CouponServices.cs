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
    public class CouponServices : IDataManipulationAsync<CouponBL>
    {
        private CouponRepo _couponRepo;

        private IMapper _mapper;

        public CouponServices(CouponRepo couponRepo, IMapper mapper) 
        {
            _couponRepo = couponRepo;
            _mapper = mapper;
        }


        public async Task CreateAsync(CouponBL item)
        {
            var couponBL = _mapper.Map<DataCoupon>(item);
            await _couponRepo.CreateAsync(couponBL);
        }

        public async Task DeleteAsync(CouponBL item)
        {
            var couponBL = _mapper.Map<DataCoupon>(item);
            await _couponRepo.DeleteAsync(couponBL);
        }

        public async Task DisposeAsync()
        {
            await _couponRepo.DisposeAsync();
        }

        public async Task<CouponBL> FindEntityByIdAsync(int id)
        {
            var couponData = await _couponRepo.FindEntityByIdAsync(id);
            var couponBL = _mapper.Map<CouponBL>(couponData);
            return couponBL;
        }

        public async Task<IEnumerable<CouponBL>> GetAllAsync()
        {
            var couponsData = await _couponRepo.GetAllAsync();
            var couponsBL = _mapper.Map<IEnumerable<CouponBL>>(couponsData);
            return couponsBL;
        }

        public async Task SaveAsync()
        {
            await _couponRepo.SaveAsync();
        }

        public async Task UpdateAsync(int id, CouponBL item)
        {
            var couponData = _mapper.Map<DataCoupon>(item);
            await _couponRepo.UpdateAsync(id, couponData);
        }

        async Task<IEnumerable<CouponBL>> IDataManipulationAsync<CouponBL>.GetAllAsync()
        {
            var couponsData = await _couponRepo.GetAllAsync();
            var couponsBL = _mapper.Map<IEnumerable<CouponBL>>(couponsData);
            return couponsBL;
        }
    }
}
