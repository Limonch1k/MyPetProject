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
    public class ProductRepo : IDataManipulationAsync<DataProduct>
    {
        private KotelContext _context;

        private IMapper _mapper;

        public ProductRepo(KotelContext context, IMapper mapper )
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(DataProduct item)
        {
            var product = _mapper.Map<Product>(item);
            await _context.Products.AddAsync(product);
        }

        public async Task DeleteAsync(DataProduct item)
        {
            var product = await _context.Products.FindAsync(item.Id);
            _context.Products.Remove(product);
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<DataProduct> FindEntityByIdAsync(int id)
        {
            var product = await _context.Products.FindAsync(id);
            var dataProduct = _mapper.Map<DataProduct>(product);
            return dataProduct;
        }

        public async Task<IEnumerable<DataProduct>> GetAllAsync()
        {
            var products = await _context.Products.ToListAsync();
            var dataProducts = _mapper.Map<IEnumerable<DataProduct>>(products);
            return dataProducts;
        }

        public async Task<IEnumerable<DataProduct>> GetAllByProductClassIdAsync(int ProductClassId)
        {
            var products = await _context.Products.Where(c => c.ProductClassId == ProductClassId).ToListAsync();
            var dataProducts = _mapper.Map<IEnumerable<DataProduct>>(products);
            return dataProducts;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, DataProduct item)
        {
            var product = await _context.Products.FindAsync(id);
            product = _mapper.Map<Product>(item);
        }
    }
}
