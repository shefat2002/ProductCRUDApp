﻿using Microsoft.AspNetCore.Mvc;
using SimpleCRUDApp.Data;
using SimpleCRUDApp.Models;

namespace SimpleCRUDApp.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _context;

        public ProductController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            IEnumerable<Product> products = _context.Products.ToList();
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create([Bind("Name, Price, Description, Stock")] Product model)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(model);
                _context.SaveChanges();
                TempData["Notification"] = "Product Created Successfully!";
                TempData["NotificationType"] = "success";
                return RedirectToAction("Index");
            }
            return View(model);
        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        [HttpPost]
        public IActionResult Edit([Bind("Id, Name, Price, Description, Stock")] Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                TempData["Notification"] = "Product Updated Successfully!";
                TempData["NotificationType"] = "success";
                return RedirectToAction("Index");
            }
            return View(product);
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var product = _context.Products.Find(id);
            if(product == null)
            {
                return NotFound();
            }
            return View(product);
        }
        public IActionResult DeleteConfirm(int id)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
                TempData["Notification"] = "Product Deleted Successfully!";
                TempData["NotificationType"] = "success";
            }
            return RedirectToAction("Index");
        }
    }
}
