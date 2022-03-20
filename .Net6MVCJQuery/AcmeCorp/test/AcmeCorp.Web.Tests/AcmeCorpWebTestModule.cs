using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AcmeCorp.EntityFrameworkCore;
using AcmeCorp.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace AcmeCorp.Web.Tests
{
    [DependsOn(
        typeof(AcmeCorpWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class AcmeCorpWebTestModule : AbpModule
    {
        public AcmeCorpWebTestModule(AcmeCorpEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AcmeCorpWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(AcmeCorpWebMvcModule).Assembly);
        }
    }
}