using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace SchoolManegment.Controllers
{
    public abstract class SchoolManegmentControllerBase: AbpController
    {
        protected SchoolManegmentControllerBase()
        {
            LocalizationSourceName = SchoolManegmentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
