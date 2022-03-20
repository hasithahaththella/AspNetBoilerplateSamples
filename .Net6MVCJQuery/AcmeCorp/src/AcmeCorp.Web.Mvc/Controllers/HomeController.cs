using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AcmeCorp.Controllers;

namespace AcmeCorp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : AcmeCorpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
