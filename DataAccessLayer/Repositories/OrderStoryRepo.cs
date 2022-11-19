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
    public class OrderStoryRepo : IDataManipulationAsync<DataOrderStory>
    {
        private KotelContext _context;

        private IMapper _mapper;

        public async Task CreateAsync(DataOrderStory item)
        {
            var order = _mapper.Map<OrderStory>(item);
            await _context.OrderStories.AddAsync(order);
        }

        public async Task DeleteAsync(DataOrderStory item)
        {
            var order = await _context.OrderStories.FindAsync(item.Id);
            _context.OrderStories.Remove(order);
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<DataOrderStory> FindEntityByIdAsync(int id)
        {
            var order = await _context.OrderStories.FindAsync(id);
            var dataOrder = _mapper.Map<DataOrderStory>(order);
            return dataOrder;
        }

        public async Task<IEnumerable<DataOrderStory>> GetAllAsync()
        {
            var order = await _context.OrderStories.ToListAsync();
            var dataOrder = _mapper.Map<IEnumerable<DataOrderStory>>(order);
            return dataOrder;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, DataOrderStory item)
        {
            var order = await _context.OrderStories.FindAsync(id);
            order = _mapper.Map<OrderStory>(item);        
        }
    }
}
