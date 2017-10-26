using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Abp.Authorization;

namespace Helios.Zero.Authorization
{
    public static class PermissionExtensions
    {
        public static Permission GetChildPermissionOrNull(this Permission permission, string name)
        {
            return permission.Children.FirstOrDefault(x => x.Name == name);
        }
    }
}
