using System.Threading.Tasks;
using AcmeCorp.Configuration.Dto;

namespace AcmeCorp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
