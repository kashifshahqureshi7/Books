using System.Threading.Tasks;
using SchoolManegment.Configuration.Dto;

namespace SchoolManegment.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
