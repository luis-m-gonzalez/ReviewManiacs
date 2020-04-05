using System.Threading.Tasks;
using ReviewManiacs.Configuration.Dto;

namespace ReviewManiacs.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
