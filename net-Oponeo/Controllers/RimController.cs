using Microsoft.AspNetCore.Mvc;
using net_Oponeo.Models;
using net_Oponeo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_Oponeo.Controllers
{
    public class RimController : Controller
    {
        private readonly IWarehouseService _warehouseService;
        public RimController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }
        [Route("felgi")]
        public IActionResult Index()
        {
            var rimList = _warehouseService.GetAllRims();
            return View(rimList);
        }
        [Route("felgi/dodaj")]
        [HttpGet]
        public IActionResult AddRim()
        {
            return View();
        }
        [Route("felgi/dodaj")]
        [HttpPost]
        public IActionResult AddRim(Rim body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }
            _warehouseService.SaveRim(body);
            return RedirectToAction("AddRim");
        }
    }
}
