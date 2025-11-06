using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ejercicio3_ApiWebApp.Controllers
{
    public class SistemasController : Controller
    {
        // GET: SistemasController
        public ActionResult Index()
        {
            return View();
        }

        // GET: SistemasController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: SistemasController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: SistemasController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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

        // GET: SistemasController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: SistemasController/Edit/5
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

        // GET: SistemasController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SistemasController/Delete/5
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
