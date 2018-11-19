using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace XTOPMS.Controllers
{
    public abstract class XTOPMSControllerBase: AbpController
    {
        protected XTOPMSControllerBase()
        {
            LocalizationSourceName = XTOPMSConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
