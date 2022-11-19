using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopM4.Data;
using ShopM4.Models;

namespace ShopM4.Controllers
{
    public class CategoryController : Controller
    {
        private ApplicationDbContext db;

        public CategoryController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            IEnumerable<Category> categories = db.Category;

            return View(categories);
        }

        // GET - Create
        public IActionResult Create()
        {
            return View();
        }

        // POST - Create
        [HttpPost]
        public IActionResult Create(Category category)
        {
            db.Category.Add(category);   
            db.SaveChanges();

            return RedirectToAction("Index");  // переход на страницу категорий
        }
    }
}

