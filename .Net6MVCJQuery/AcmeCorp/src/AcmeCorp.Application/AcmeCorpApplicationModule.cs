using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using AcmeCorp.Authorization;

namespace AcmeCorp
{
    [DependsOn(
        typeof(AcmeCorpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class AcmeCorpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<AcmeCorpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(AcmeCorpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
