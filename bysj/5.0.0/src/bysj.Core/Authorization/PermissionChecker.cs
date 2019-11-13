using Abp.Authorization;
using bysj.Authorization.Roles;
using bysj.Authorization.Users;

namespace bysj.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
