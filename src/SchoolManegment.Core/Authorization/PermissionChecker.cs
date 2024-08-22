using Abp.Authorization;
using SchoolManegment.Authorization.Roles;
using SchoolManegment.Authorization.Users;

namespace SchoolManegment.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
