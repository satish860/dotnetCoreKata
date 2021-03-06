﻿using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SaveFood.Models;
using SaveFood.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SaveFood.Controllers
{
    [Authorize]
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

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Resturant resturant)
        {
            if (ModelState.IsValid)
            {
                this.ResturantData.SaveResturant(resturant);
                return RedirectToAction(nameof(Index));
            }
            else
            {
                return View();
            }
        }
    }
}
