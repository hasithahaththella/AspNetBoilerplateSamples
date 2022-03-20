using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using AcmeCorp.Controllers;

namespace AcmeCorp.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : AcmeCorpControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
