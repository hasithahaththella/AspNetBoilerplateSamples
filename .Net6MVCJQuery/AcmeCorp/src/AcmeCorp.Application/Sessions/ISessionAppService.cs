using System.Threading.Tasks;
using Abp.Application.Services;
using AcmeCorp.Sessions.Dto;

namespace AcmeCorp.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
