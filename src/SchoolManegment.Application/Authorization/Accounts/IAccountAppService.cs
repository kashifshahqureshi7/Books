using System.Threading.Tasks;
using Abp.Application.Services;
using SchoolManegment.Authorization.Accounts.Dto;

namespace SchoolManegment.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
