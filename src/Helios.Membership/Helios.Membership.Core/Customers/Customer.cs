using System;
using System.Collections.Generic;
using System.Text;
using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;

namespace Helios.Membership.Customers
{
    public class Customer : FullAuditedEntity<long>, IMustHaveTenant
    {
        public int TenantId { get; set; }

        public long UserId { get; set; }
    }
}
