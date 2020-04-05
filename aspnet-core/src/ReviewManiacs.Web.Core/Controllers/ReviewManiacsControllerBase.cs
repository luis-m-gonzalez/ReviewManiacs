using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace ReviewManiacs.Controllers
{
    public abstract class ReviewManiacsControllerBase: AbpController
    {
        protected ReviewManiacsControllerBase()
        {
            LocalizationSourceName = ReviewManiacsConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
