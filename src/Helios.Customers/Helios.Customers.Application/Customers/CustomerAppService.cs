using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Authorization;
using Helios.Authorization;

namespace Helios.Customers
{
    [AbpAuthorize(HeliosCustomersAppPermissions.Pages_Customers)]
    public class CustomerAppService : HeliosCustomersAppServiceBase, ICustomerAppService
    {
        public Task CreateCustomer()
        {
            throw new NotImplementedException();
        }
    }
}
