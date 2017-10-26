using System;
using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Helios;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace Helios.Web.Controllers
{
    public abstract class HeliosZeroControllerBase : AbpController
    {
        protected HeliosZeroControllerBase()
        {
            LocalizationSourceName = HeliosZeroConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }

        protected void SetTenantIdCookie(int? tenantId)
        {
            Response.Cookies.Append(
                "Abp.TenantId",
                tenantId?.ToString(),
                new CookieOptions
                {
                    Expires = DateTimeOffset.Now.AddYears(5),
                    Path = "/"
                }
            );
        }
    }
}