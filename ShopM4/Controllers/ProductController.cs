using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopM4.Data;
using ShopM4.Models;

namespace ShopM4.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext db;

        public ProductController(ApplicationDbContext db)
        {
            this.db = db;
        }

        // GET INDEX
        public IActionResult Index()
        {
            IEnumerable<Product> objList = db.Product;

            return View(objList);
        }

        // GET - CreateEdit
        public IActionResult CreateEdit(int? id)
        {
            Product product = new Product();

            if (id == null)
            {
                // create product
                return View(product);
            }
            else
            {
                // edit product
                product = db.Product.Find(id);
                if (product == null)
                {
                    return NotFound();
                }
                return View(product);
            }
        }
    }
}

