using Microsoft.AspNetCore.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SupplierController : Controller
    {
        ISupplier _repo;
        public SupplierController(ISupplier repo)
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
        public IActionResult Create(Supplier supplier)
        {
            _repo.Create(supplier);
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            Supplier supplier = _repo.GetUserById(id);
            return View(supplier);
        }
        [HttpPost]
        public IActionResult Deleted(int SupplierId)
        {
            _repo.Delete(SupplierId);
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            Supplier obj= _repo.GetUserById(id);
            return View(obj);
        }
        [HttpPost]
        public IActionResult Edit(int id, Supplier supplier)
        {
            _repo.edit(id, supplier);
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            return View(_repo.GetUserById(id));
        }
    }
}
