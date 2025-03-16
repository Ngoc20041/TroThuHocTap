using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TroThuHocTap.Controllers
{
    public class ChatController : Controller
    {
        // GET: HomeChat
        public ActionResult Index()
        {
            return View();
        }

        // GET: HomeChat/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HomeChat/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HomeChat/Create
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

        // GET: HomeChat/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HomeChat/Edit/5
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

        // GET: HomeChat/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HomeChat/Delete/5
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
