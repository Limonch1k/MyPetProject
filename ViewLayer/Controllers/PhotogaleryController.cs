﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KotelSite.Controllers
{
    public class PhotogaleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
