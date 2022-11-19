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
    public class ProductClassRepo : IDataManipulationAsync<DataProductClass>
    {
        private KotelContext _context;

        private IMapper _mapper;

        public ProductClassRepo(KotelContext context, IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task CreateAsync(DataProductClass item)
        {
            var productClass = _mapper.Map<ProductClass>(item);
            await _context.AddAsync(productClass);
        }

        public async Task DeleteAsync(DataProductClass item)
        {
            var productClass = await _context.ProductClasses.FindAsync(item.Id);
            _context.ProductClasses.Remove(productClass);
        }

        public async Task DisposeAsync()
        {
            await _context.DisposeAsync();
        }

        public async Task<DataProductClass> FindEntityByIdAsync(int id)
        {
            var productClass = await _context.ProductClasses.FindAsync(id);
            var dataProductClass = _mapper.Map<DataProductClass>(productClass);
            return dataProductClass;
        }

        public async Task<IEnumerable<DataProductClass>> GetAllAsync()
        {
            var productClassList = await _context.ProductClasses.ToListAsync();
            var DataProductClassList = _mapper.Map<List<DataProductClass>>(productClassList);
            return DataProductClassList;
        }

        public async Task SaveAsync()
        {
            await _context.SaveChangesAsync();
        }

        public async Task UpdateAsync(int id, DataProductClass item)
        {
            var productClass = await _context.ProductClasses.FindAsync(id);
            var dataProductClass = _mapper.Map<ProductClass>(item);
            productClass.Id = dataProductClass.Id;
            productClass.LinkToImage = dataProductClass.LinkToImage;
            productClass.NameOfProduct = dataProductClass.NameOfProduct;
            productClass.Products = dataProductClass.Products;
            
        }
    }
}
