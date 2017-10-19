using Abp.Authorization;
using Helios.Authorization.Roles;
using Helios.Authorization.Users;

namespace Helios.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
