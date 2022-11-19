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
    public class ProductServices : IDataManipulationAsync<ProductBL>
    {
        private ProductRepo _productRepo;

        private IMapper _mapper;

        public ProductServices(ProductRepo productRepo, IMapper mapper) 
        {
            _productRepo = productRepo;
            _mapper = mapper;
        }
        public async Task CreateAsync(ProductBL item)
        {
            var product = _mapper.Map<DataProduct>(item);
            await _productRepo.CreateAsync(product);
        }

        public async Task DeleteAsync(ProductBL item)
        {
            var product = _mapper.Map<DataProduct>(item);
            await _productRepo.DeleteAsync(product);
        }

        public async Task DisposeAsync()
        {
            await _productRepo.DisposeAsync();
        }

        public async Task<ProductBL> FindEntityByIdAsync(int id)
        {
            var productData = await _productRepo.FindEntityByIdAsync(id);
            var productBL = _mapper.Map<ProductBL>(productData);
            return productBL;
        }

        public async Task<IEnumerable<ProductBL>> GetAllAsync()
        {
            var productsData = await _productRepo.GetAllAsync();
            var productsBL = _mapper.Map<IEnumerable<ProductBL>>(productsData);
            return productsBL;
        }

        public async Task<IEnumerable<ProductBL>> GetAllByProductClassIdAsync(int ProductClassId)
        {
            var productsData = await _productRepo.GetAllByProductClassIdAsync(ProductClassId);
            var productsBL = _mapper.Map<IEnumerable<ProductBL>>(productsData);
            return productsBL;
        }

        public async Task SaveAsync()
        {
            await _productRepo.SaveAsync();
        }

        public async Task UpdateAsync(int id, ProductBL item)
        {
            var productsData = _mapper.Map<DataProduct>(item);
            await _productRepo.UpdateAsync(id, productsData);
        }
    }
}
