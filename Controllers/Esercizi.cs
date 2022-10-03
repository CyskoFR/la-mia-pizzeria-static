using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_static.Controllers
{
    public class Esercizi : Controller
    {
        // GET: Esercizi
        public ActionResult Index()
        {
            return View();
        }

        // GET: Esercizi/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Esercizi/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Esercizi/Create
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

        // GET: Esercizi/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Esercizi/Edit/5
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

        // GET: Esercizi/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Esercizi/Delete/5
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
