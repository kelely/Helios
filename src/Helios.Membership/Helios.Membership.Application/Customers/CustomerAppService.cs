using System;
using System.Collections.Generic;
using System.Text;
using Abp.Authorization;
using Helios.Membership.Authorization;

namespace Helios.Membership.Customers
{
    [AbpAuthorize(AppPermissions.Pages_Customers)]
    public class CustomerAppService : HeliosMembershipAppServiceBase, ICustomerAppService
    {

    }
}
