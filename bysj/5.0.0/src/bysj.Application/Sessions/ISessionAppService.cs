using System.Threading.Tasks;
using Abp.Application.Services;
using bysj.Sessions.Dto;

namespace bysj.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
