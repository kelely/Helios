using Abp.Authorization;
using Helios.Zero.Authorization.Roles;
using Helios.Zero.Authorization.Users;

namespace Helios.Zero.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
