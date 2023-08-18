using EmployeeApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace EmployeeApp.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _db;
        public EmployeeController(ApplicationDbContext db)
        {
            _db = db;
        }


        // GET: Employees
        public IActionResult Index()
        {
            List<EmployeeModel> employees = _db.Employees.ToList();
            return View(employees);
        }

        // GET: Employees/Details/5
        [HttpGet("All")]
        public IActionResult Details(int id)
        {
            EmployeeModel employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // GET: Employees/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Employees/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(EmployeeModel employee)
        {
            if(employee != null)
            {
                _db.Employees.Add(employee);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            

            return View(employee);
        }

        // GET: Employees/Edit/5
        public IActionResult Edit(int id)
        {
            EmployeeModel employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Edit/5
        [HttpPost]
        public ActionResult Edit(EmployeeModel employee)
        {
            if (ModelState.IsValid)
            {
                _db.Entry(employee).State = EntityState.Modified;
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        // GET: Employees/Delete/5
        public ActionResult Delete(int id)
        {
            EmployeeModel employee = _db.Employees.Find(id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Employees/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EmployeeModel employee = _db.Employees.Find(id);
            _db.Employees.Remove(employee);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}