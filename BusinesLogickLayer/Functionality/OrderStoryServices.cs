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
    public class OrderStoryServices : IDataManipulationAsync<OrderStoryBL>
    {
        private OrderStoryRepo _orderStoryRepo;

        private IMapper _mapper;

        public OrderStoryServices(OrderStoryRepo orderStoryRepo, IMapper mapper) 
        {
            _orderStoryRepo = orderStoryRepo;
            _mapper = mapper;
        }

        public async Task CreateAsync(OrderStoryBL item)
        {
            var orderStoryData = _mapper.Map<DataOrderStory>(item);
            await _orderStoryRepo.CreateAsync(orderStoryData);
        }

        public async Task DeleteAsync(OrderStoryBL item)
        {
            var orderStoryData = _mapper.Map<DataOrderStory>(item);
            await _orderStoryRepo.DeleteAsync(orderStoryData);
        }

        public async Task DisposeAsync()
        {
            await _orderStoryRepo.DisposeAsync();
        }

        public async Task<OrderStoryBL> FindEntityByIdAsync(int id)
        {
            var orderStoryData = await _orderStoryRepo.FindEntityByIdAsync(id);
            var orderStoryBL = _mapper.Map<OrderStoryBL>(orderStoryData);
            return orderStoryBL;
        }

        public async Task<IEnumerable<OrderStoryBL>> GetAllAsync()
        {
            var ordersStoryData = await _orderStoryRepo.GetAllAsync();
            var ordersStoryBL = _mapper.Map<IEnumerable<OrderStoryBL>>(ordersStoryData);
            return ordersStoryBL;
        }

        public async Task SaveAsync()
        {
            await _orderStoryRepo.SaveAsync();
        }

        public async Task UpdateAsync(int id, OrderStoryBL item)
        {
            var orderStoryData = _mapper.Map<DataOrderStory>(item);
            await _orderStoryRepo.UpdateAsync(id, orderStoryData);
        }
    }
}
