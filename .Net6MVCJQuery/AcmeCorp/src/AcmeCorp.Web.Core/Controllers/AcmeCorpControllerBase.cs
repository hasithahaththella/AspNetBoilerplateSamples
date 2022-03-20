using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace AcmeCorp.Controllers
{
    public abstract class AcmeCorpControllerBase: AbpController
    {
        protected AcmeCorpControllerBase()
        {
            LocalizationSourceName = AcmeCorpConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
