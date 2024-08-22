using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using SchoolManegment.Configuration.Dto;

namespace SchoolManegment.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : SchoolManegmentAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
