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
    public class ProductClassServices : IDataManipulationAsync<ProductClassBL>
    {
        private ProductClassRepo _orderStoryRepo;

        private IMapper _mapper;

        public ProductClassServices(ProductClassRepo orderStoryRepo, IMapper mapper)
        {
            _orderStoryRepo = orderStoryRepo;
            _mapper = mapper;
        }

        public async Task CreateAsync(ProductClassBL item)
        {
            var productClass = _mapper.Map<DataProductClass>(item);
            await _orderStoryRepo.CreateAsync(productClass);
        }

        public async Task DeleteAsync(ProductClassBL item)
        {
            var productClass = await _orderStoryRepo.FindEntityByIdAsync(item.Id);
            await _orderStoryRepo.DeleteAsync(productClass);
        }

        public async Task DisposeAsync()
        {
            await _orderStoryRepo.DisposeAsync();
        }

        public async Task<ProductClassBL> FindEntityByIdAsync(int id)
        {
            var productClass = await _orderStoryRepo.FindEntityByIdAsync(id);
            var dataProductClass = _mapper.Map<ProductClassBL>(productClass);
            return dataProductClass;
        }

        public async Task<IEnumerable<ProductClassBL>> GetAllAsync()
        {
            var productClassList = await _orderStoryRepo.GetAllAsync();
            var DataProductClassList = _mapper.Map<List<ProductClassBL>>(productClassList);
            return DataProductClassList;
        }

        public async Task SaveAsync()
        {
            await _orderStoryRepo.SaveAsync();
        }

        public async Task UpdateAsync(int id, ProductClassBL item)
        {
            var productClass = await _orderStoryRepo.FindEntityByIdAsync(id);
            var dataProductClass = _mapper.Map<ProductClassBL>(item);
            productClass.Id = dataProductClass.Id;
            productClass.LinkToImage = dataProductClass.LinkToImage;
            productClass.NameOfProduct = dataProductClass.NameOfProduct;
        }
    }
}
