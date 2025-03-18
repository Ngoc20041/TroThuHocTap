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
        public ActionResult Feature()
        {
            return View();
        }
        public ActionResult Contract()
        {
            return View();
        }
    }
}
