using System.Web.Mvc;

namespace TB.Web.Controllers
{
    public class AboutController : TBControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}