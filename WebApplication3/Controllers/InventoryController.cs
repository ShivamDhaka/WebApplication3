using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class InventoryController : Controller
    {
        IInventory _repo;
        public InventoryController(IInventory repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            return View(_repo.GetDetails());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Inventory inventory)
        {
            _repo.Create(inventory);
            return RedirectToAction("Index");
        }
        public IActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Delete(int id)
        {
            _repo.Delete(id);
            return View();
        }
        public IActionResult Edit()
        {
            return View();
        }
        public IActionResult Edit(int id, Inventory inventory)
        {
            _repo.edit(id, inventory);
            return RedirectToAction("Index");
        }


    }
}
