using System.Threading.Tasks;
using Abp.Application.Services;
using TB.Roles.Dto;

namespace TB.Roles
{
    public interface IRoleAppService : IApplicationService
    {
        Task UpdateRolePermissions(UpdateRolePermissionsInput input);
    }
}
