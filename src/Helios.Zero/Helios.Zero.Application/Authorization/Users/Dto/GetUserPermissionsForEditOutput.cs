using System.Collections.Generic;
using Helios.Zero.Authorization.Permissions.Dto;

namespace Helios.Zero.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}