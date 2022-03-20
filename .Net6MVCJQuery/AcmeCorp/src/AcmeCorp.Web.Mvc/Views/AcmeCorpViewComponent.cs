using Abp.AspNetCore.Mvc.ViewComponents;

namespace AcmeCorp.Web.Views
{
    public abstract class AcmeCorpViewComponent : AbpViewComponent
    {
        protected AcmeCorpViewComponent()
        {
            LocalizationSourceName = AcmeCorpConsts.LocalizationSourceName;
        }
    }
}
