using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BasicMvcCore3.n.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMvcCore3.n.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(ProductEditModel model)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                ////check product name exist
                //if (model.Name=="test")
                //{
                //    ModelState.AddModelError("", "this product name was existed");
                //    return View(model);
                //}
                // check name name exist
               
                message = "product " + model.Name + " Rate " + model.Rate.ToString() + " With Rating " + model.Rating.ToString() + " created successfully";
            }
            else
            {
                return View(model);
            }
            return Content(message);
        }



        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(ProductEditModel model)
        {
            string message = "";

            if (ModelState.IsValid)
            {
                message = "product " + model.Name + " Rate " + model.Rate.ToString() + " With Rating " + model.Rating.ToString() + " created successfully";
            }
            else
            {
                message = "Failed to create the product. Please try again";
            }
            return Content(message);
        }
    }
}
