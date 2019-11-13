using System.Threading.Tasks;
using Abp.Application.Services;
using bysj.Configuration.Dto;

namespace bysj.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}