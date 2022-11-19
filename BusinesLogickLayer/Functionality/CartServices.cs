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
    public class CartServices : IDataManipulationAsync<CartBL>
    {
        private CartRepo _cartRepo;

        private IMapper _mapper;

        public CartServices(CartRepo cartRepo, IMapper mapper) 
        {
            _cartRepo = cartRepo;
            _mapper = mapper;
        }
        
        public async Task CreateAsync(CartBL item)
        {
            var cart = _mapper.Map<DataCart>(item);
            await _cartRepo.CreateAsync(cart);
        }

        public async Task DeleteAsync(CartBL item)
        {
            var cart = _mapper.Map<DataCart>(item);
            await _cartRepo.DeleteAsync(cart);
        }

        public async Task DisposeAsync()
        {
           await _cartRepo.DisposeAsync();
        }

        public async Task<CartBL> FindEntityByIdAsync(int id)
        {
            var dataCart =  await _cartRepo.FindEntityByIdAsync(id);
            var dataBL = _mapper.Map<CartBL>(dataCart);
            return dataBL;
        }

        public async Task<IEnumerable<CartBL>> GetAllAsync()
        {
            var carts = await _cartRepo.GetAllAsync();
            var cartsBL = _mapper.Map<IEnumerable<CartBL>>(carts);
            return cartsBL;
        }

        public async Task SaveAsync()
        {
            await _cartRepo.SaveAsync();
        }

        public async Task UpdateAsync(int id, CartBL item)
        {
            var cartsBL = _mapper.Map<DataCart>(item);
            await _cartRepo.UpdateAsync(id, cartsBL);
        }
    }
}
