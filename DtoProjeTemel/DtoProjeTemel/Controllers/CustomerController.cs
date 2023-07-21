using DtoProjeTemel.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DtoProjeTemel.Controllers
{
    public class CustomerController : Controller
    {
     Context Context = new Context();

     
        public IActionResult GetList()
        {
          var data=Context.Customers.ToList();
            return View(data);
        }

        // GET: CustomerController/Details/5
        public ActionResult CustomerDto()
        {

            var data = Context
                .Customers
                .ToList();
            return View(data);
        }

        // GET: CustomerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: CustomerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Customer customers)
        {
            try
            {
                using (var context = new Context())
                {
                    var addedEntity = context.Entry(customers);
                    addedEntity.State = EntityState.Added;
                    context.SaveChanges();
                }
                return RedirectToAction("GetList");
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: CustomerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: CustomerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: CustomerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
