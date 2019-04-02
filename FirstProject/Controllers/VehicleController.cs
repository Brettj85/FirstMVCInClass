using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstProject.Controllers
{
    public class VehicleController : Controller
    {
        public IActionResult Index()
        {
            var car = new Car();
            car.Vin = 123456;
            car.Color = "Red";
            return View(car); //views/vehicle/index <----- Car (model)
        }
    }
    //model
    public class Car
    {
        public int Vin { get; set; }
        public string Color { get; set; }
    }
}