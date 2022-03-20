using Abp.Authorization;
using AcmeCorp.Authorization.Roles;
using AcmeCorp.Authorization.Users;

namespace AcmeCorp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
