using Abp.Authorization;
using ReviewManiacs.Authorization.Roles;
using ReviewManiacs.Authorization.Users;

namespace ReviewManiacs.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
