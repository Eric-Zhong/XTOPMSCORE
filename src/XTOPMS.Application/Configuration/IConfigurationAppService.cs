using System.Threading.Tasks;
using XTOPMS.Configuration.Dto;

namespace XTOPMS.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
