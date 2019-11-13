using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using bysj.Configuration.Dto;

namespace bysj.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : bysjAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
