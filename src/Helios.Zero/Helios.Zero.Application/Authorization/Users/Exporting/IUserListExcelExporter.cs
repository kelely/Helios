using System.Collections.Generic;
using Helios.Zero.Authorization.Users.Dto;
using Helios.Zero.Dto;

namespace Helios.Zero.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}