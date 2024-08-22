using System.Threading.Tasks;
using Abp.Application.Services;
using SchoolManegment.Sessions.Dto;

namespace SchoolManegment.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
