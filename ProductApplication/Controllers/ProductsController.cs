using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProductApplication.Data;
using ProductApplication.Models;

namespace ProductApplication.Controllers
{
    public class ProductsController : Controller
    {
        private readonly AppDbContext _context;

        public ProductsController(AppDbContext context)
        {
            _context = context;
        }
        //public IActionResult Index() // For displaying all products
        //{
        //    var products = _context.Products.Include(p => p.Category).ToList();
        //    return View(products);
        //}

        public IActionResult Index(int page = 1, int pageSize = 10)
        {
            int totalProducts = _context.Products.Count(); // Get total product count

            var products = _context.Products
                                   .Include(p => p.Category) // Include category
                                   .OrderBy(p => p.ProductId)
                                   .Skip((page - 1) * pageSize) // Skip previous pages
                                   .Take(pageSize) // Take only `pageSize` products
                                   .ToList();

            ViewBag.CurrentPage = page;
            ViewBag.TotalPages = (int)Math.Ceiling((double)totalProducts / pageSize); // Calculate total pages
            ViewBag.PageSize = pageSize; // Add pageSize to ViewBag for pagination links

            return View(products); // Send only paginated products
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName");
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Product product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            // Reload Categories if validation fails
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);

            return View(product);
        }


        public IActionResult Edit(int id) // For updating a product
        {
            var product = _context.Products.Find(id);
            if (product == null)
            {
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(Product product) // For saving the updated product
        {
            if (ModelState.IsValid)
            {
                _context.Products.Update(product);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Categories = new SelectList(_context.Categories, "CategoryId", "CategoryName", product.CategoryId);
            return View(product);
        }

        [HttpPost]
        public IActionResult Delete(int id, int page = 1, int pageSize = 10)
        {
            var product = _context.Products.Find(id);
            if (product != null)
            {
                _context.Products.Remove(product);
                _context.SaveChanges();
            }

            return RedirectToAction("Index", new { page = page, pageSize = pageSize });
        }
    }
}
