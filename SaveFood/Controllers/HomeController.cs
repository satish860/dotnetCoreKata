using Microsoft.AspNetCore.Mvc;
using SaveFood.Models;
using SaveFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveFood.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(IResturantData resturantData)
        {
            ResturantData = resturantData;
        }

        public IResturantData ResturantData { get; }

        public IActionResult Index()
        {
            var model = this.ResturantData.GetResturants();
            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = this.ResturantData.GetResturant(id);
            return View(model);
        }
    }
}
