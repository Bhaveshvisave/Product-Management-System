using Microsoft.AspNetCore.Mvc;
using ProductApplication.Data;
using ProductApplication.Models;

namespace ProductApplication.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _context;

        public CategoryController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index() // For displaying all categories
        {
            var categories = _context.Categories.ToList();
            return View(categories);
        }

        public IActionResult Create() // For creating a new category
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category category) // For saving the new category
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Add(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Edit(int id) // For editing a category
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            return View(category);
        }

        [HttpPost]
        public IActionResult Edit(Category category) // For saving the edited category
        {
            if (ModelState.IsValid)
            {
                _context.Categories.Update(category);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(category);
        }

        public IActionResult Delete(int id) // For deleting a category
        {
            var category = _context.Categories.Find(id);
            if (category == null)
            {
                return RedirectToAction("Index");
            }
            _context.Categories.Remove(category);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
