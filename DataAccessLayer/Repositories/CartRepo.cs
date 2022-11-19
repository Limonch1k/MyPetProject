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
    public class CartRepo : IDataManipulationAsync<DataCart>
    {
        private KotelContext _context;

        private IMapper _mapper;

        public CartRepo(KotelContext kotelContext, IMapper mapper) 
        {
            _context = kotelContext;
            _mapper = mapper;
        }


        public async Task CreateAsync(DataCart item)
        {
            var cart = _mapper.Map<Cart>(item);
            await _context.Carts.AddAsync(cart);
        }

        public async Task DeleteAsync(DataCart item)
        {
            var cart = await _context.Users.FindAsync(item.Id);
            if (cart is null)
            {
                throw new Exception("I do nothing");
            }
            _context.Users.Remove(cart);
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<DataCart> FindEntityByIdAsync(int id)
        {
            var cart = await _context.Carts.FindAsync(id);
            if (cart is null) 
            {
                throw new Exception("do nothing");
            }

            var dataCart = _mapper.Map<DataCart>(cart);
            return dataCart;
        }

        public async Task<IEnumerable<DataCart>> GetAllAsync()
        {
            var carts = await _context.Carts.ToListAsync();
            if (carts is null) 
            {
                throw new Exception("do nothing");
            }

            var dataCart = _mapper.Map<IEnumerable<DataCart>>(carts);

            return dataCart;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, DataCart item)
        {
            var cart = await _context.Carts.FindAsync(id);
            if (cart is null)
            {
                throw new Exception("nothing");
            }
            cart = _mapper.Map<Cart>(item);
        }
    }
}
