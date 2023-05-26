using Microsoft.AspNetCore.Mvc;
using net_Oponeo.Models;
using net_Oponeo.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace net_Oponeo.Controllers
{
    public class TireController : Controller
    {
        private readonly IWarehouseService _warehouseService;
        public TireController(IWarehouseService warehouseService)
        {
            _warehouseService = warehouseService;
        }
        [Route("opony")]
        public IActionResult Index()
        {
            var tireList = _warehouseService.GetAllTires();
            return View(tireList);
        }
        [Route("opony/dodaj")]
        [HttpGet]
        public IActionResult AddTire()
        {
            return View();
        }
        [Route("opony/dodaj")]
        [HttpPost]
        public IActionResult AddTire(Tire body)
        {
            if (!ModelState.IsValid)
            {
                return View(body);
            }
            _warehouseService.SaveTire(body);
            return RedirectToAction("AddTire");
        }
    }
}
