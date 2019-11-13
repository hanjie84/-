using System.Threading.Tasks;
using Abp.Application.Services;
using bysj.Authorization.Accounts.Dto;

namespace bysj.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
