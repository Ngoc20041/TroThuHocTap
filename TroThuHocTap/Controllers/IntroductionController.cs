using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TroThuHocTap.Controllers
{
    public class IntroductionController : Controller
    {
        // GET: IntroductionController
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Test()
        {
            return View();
        }
        // GET: IntroductionController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: IntroductionController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IntroductionController/Create
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

        // GET: IntroductionController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: IntroductionController/Edit/5
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

        // GET: IntroductionController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: IntroductionController/Delete/5
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
