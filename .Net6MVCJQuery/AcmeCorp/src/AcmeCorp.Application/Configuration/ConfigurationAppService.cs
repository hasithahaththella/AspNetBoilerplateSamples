using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using AcmeCorp.Configuration.Dto;

namespace AcmeCorp.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : AcmeCorpAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
