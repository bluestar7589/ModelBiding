using Microsoft.AspNetCore.Mvc;
using ModelBiding.Models;

namespace ModelBiding.Controllers
{
    public class ProductController : Controller
    {
        // Get: /Product/Create
        [HttpGet] // This action is hit when the user navigates to the page
        public IActionResult Create()
        {
            return View();
        }

        // Post: /Product/Create
        [HttpPost] // This action is hit after the user submit form data
        public IActionResult Create(IFormCollection form)
        {
            // Validate all data

            Products p = new()
            {
                Title = form["Title"],
                Price = double.Parse(form["Price"]),
                Quantity = int.Parse(form["Quantity"])
            };
            

            // Add to database
            //ProductDb.Add(p);
            // Return a view

            return RedirectToAction("Index","Home");
        }

        [HttpGet]
        public IActionResult CreateWithModelBiding() {
            return View();
        }

        [HttpPost]
        public IActionResult CreateWithModelBiding(Products p) {
            // Validate all data
            if (ModelState.IsValid) {
                // Add to database
                //ProductDb.Add(p);    
                return RedirectToAction("Index", "Home");
            }
            // If the data is not valid, return the same page with same data - error message
            return View(p);
            
        }
    }
}
