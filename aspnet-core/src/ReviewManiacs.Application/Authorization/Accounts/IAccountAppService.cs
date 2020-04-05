using System.Threading.Tasks;
using Abp.Application.Services;
using ReviewManiacs.Authorization.Accounts.Dto;

namespace ReviewManiacs.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
