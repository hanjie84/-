using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using bysj.Roles.Dto;
using bysj.Users.Dto;

namespace bysj.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}