using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AcmeCorp.Configuration;

namespace AcmeCorp.Web.Host.Startup
{
    [DependsOn(
       typeof(AcmeCorpWebCoreModule))]
    public class AcmeCorpWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public AcmeCorpWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AcmeCorpWebHostModule).GetAssembly());
        }
    }
}
