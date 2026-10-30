using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Day3_Bui_Ngoc_Thang_D.Data;
using Day3_Bui_Ngoc_Thang_D.Models;

namespace Day3_Bui_Ngoc_Thang_D.Controllers
{
    public class CategoryController : Controller
    {
        // GET: CategoryController
        public ActionResult Index()
        {
            return View(SaveData.categories);
        }

        // GET: CategoryController/Details/5
        public ActionResult Details(int id)
        {
            var category = SaveData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // GET: CategoryController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CategoryController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([FromForm] Category category)
        {
            if (ModelState.IsValid)
            {
                SaveData.categories.Add(category);
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: CategoryController/Edit/5
        public ActionResult Edit(int id)
        {
            var category = SaveData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Category category)
        {
            if (ModelState.IsValid)
            {
                var existing = SaveData.categories.FirstOrDefault(c => c.Id == id);
                if (existing != null)
                {
                    existing.Name = category.Name;
                    existing.Description = category.Description;
                }
                return RedirectToAction(nameof(Index));
            }
            return View(category);
        }

        // GET: CategoryController/Delete/5
        public ActionResult Delete(int id)
        {
            var category = SaveData.categories.FirstOrDefault(c => c.Id == id);
            if (category == null)
            {
                return NotFound();
            }
            return View(category);
        }

        // POST: CategoryController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            var category = SaveData.categories.FirstOrDefault(c => c.Id == id);
            if (category != null)
            {
                SaveData.categories.Remove(category);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
