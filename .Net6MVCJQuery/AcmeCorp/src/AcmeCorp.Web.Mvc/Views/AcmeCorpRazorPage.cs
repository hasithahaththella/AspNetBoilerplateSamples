using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;
using Microsoft.AspNetCore.Mvc.Razor.Internal;

namespace AcmeCorp.Web.Views
{
    public abstract class AcmeCorpRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected AcmeCorpRazorPage()
        {
            LocalizationSourceName = AcmeCorpConsts.LocalizationSourceName;
        }
    }
}
