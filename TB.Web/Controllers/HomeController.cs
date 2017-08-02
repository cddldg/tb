using System.Web.Mvc;
using Abp.Web.Mvc.Authorization;

namespace TB.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : TBControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}