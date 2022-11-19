using AutoMapper;
using BusinesLogicLayer.Functionality;
using BusinesLogicLayer.Model;
using KotelSite.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Controllers
{
    public class ContactsController : Controller
    {
        private IMapper _mapper { get; set; }
        private UserRequestServices _userRequest { get; set; } 
        public ContactsController(IMapper mapper, UserRequestServices userRequest) 
        {
            _mapper = mapper;
            _userRequest = userRequest;
        }

        [HttpPost]
        [Route("RequestCall")]
        public async Task<IActionResult> RequestCall([FromForm] RequestCallPL requestPL)
        {
            try
            {
                var userBL = _mapper.Map<UserRequestBL>(requestPL);
                await _userRequest.CreateRequestCall(userBL);
            }
            catch (Exception e)
            {
                ViewBag.Message = e.Message;
                return BadRequest();
            }
            return Ok();
        }
    }
}
