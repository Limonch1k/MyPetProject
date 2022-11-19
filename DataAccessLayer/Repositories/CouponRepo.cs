using AutoMapper;
using DataAccessLayer.DataModel;
using DataAccessLayer.Interface;
using DataAccessLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repositories
{
    public class CouponRepo : IDataManipulationAsync<DataCoupon>
    {
        private KotelContext _context;

        private IMapper _mapper;

        public CouponRepo(KotelContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(DataCoupon item)
        {
            var coupon = _mapper.Map<Coupon>(item);
            await _context.Coupons.AddAsync(coupon);
        }

        public async Task DeleteAsync(DataCoupon item)
        {
            var coupon = await _context.Coupons.FindAsync(item.Id);
            coupon = _mapper.Map<Coupon>(item);
            _context.Coupons.Remove(coupon);
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<DataCoupon> FindEntityByIdAsync(int id)
        {
            var coupon = await _context.Coupons.FindAsync(id);
            var dataCoupon = _mapper.Map<DataCoupon>(coupon);
            return dataCoupon;
        }

        public async Task<IEnumerable<DataCoupon>> GetAllAsync()
        {
            var coupons = await _context.Coupons.ToListAsync();
            var dataCoupons = _mapper.Map<IEnumerable<DataCoupon>>(coupons);
            return dataCoupons;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, DataCoupon item)
        {
            var coupon = await _context.Coupons.FindAsync(id);
            if (coupon is null) 
            {
                throw new Exception("DO NOTHING");
            }
            coupon = _mapper.Map<Coupon>(item);
        }
    }
}
