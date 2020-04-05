using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using ReviewManiacs.Configuration.Dto;

namespace ReviewManiacs.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : ReviewManiacsAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
