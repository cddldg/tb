using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using TB.MultiTenancy.Dto;

namespace TB.MultiTenancy
{
    public interface ITenantAppService : IApplicationService
    {
        ListResultDto<TenantListDto> GetTenants();

        Task CreateTenant(CreateTenantInput input);
    }
}
