using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusinesLogicLayer;
using BusinesLogicLayer.Functionality;
using AutoMapper;
using KotelSite.Models;

namespace KotelSite.Controllers
{
    public class CatalogController : Controller
    {
        private ProductClassServices _productClassServices;

        private ProductServices _productServices;
        
        private IMapper _mapper;
        public CatalogController(ProductClassServices productClassServices, ProductServices productServices, IMapper mapper) 
        {
            _productClassServices = productClassServices;
            _productServices = productServices;
            _mapper = mapper;
        }

        [HttpGet]
        [Route("TypeCatalog")]
        public async Task<IActionResult> TypeCatalogAsync() 
        {
            var listOfProductClassBL = await _productClassServices.GetAllAsync();
            var listOfProductClassPL = _mapper.Map<List<ProductClassPL>>(listOfProductClassBL);
            return View(listOfProductClassPL);
        }

        [HttpGet]
        [Route("CatalogProduct")]
        public async Task<IActionResult> CatalogProductAsync(int Id) 
        {
            var listOfProductBL = await _productServices.GetAllByProductClassIdAsync(Id);
            var listOfProductPL = _mapper.Map<List<ProductPL>>(listOfProductBL);
            return View(listOfProductPL);
        }

        

        [HttpGet("ListOfProduct")]
        public async Task<IActionResult> ListOfProductAsync()
        {
            var listOfProductBL = (await _productClassServices.GetAllAsync()).ToList();
            var listOfProductPL = _mapper.Map<List<ProductPL>>(listOfProductBL);
            return Json(listOfProductPL);
        }
    }
}
