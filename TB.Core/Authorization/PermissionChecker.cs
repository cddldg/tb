using Abp.Authorization;
using TB.Authorization.Roles;
using TB.MultiTenancy;
using TB.Users;

namespace TB.Authorization
{
    public class PermissionChecker : PermissionChecker<Tenant, Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
