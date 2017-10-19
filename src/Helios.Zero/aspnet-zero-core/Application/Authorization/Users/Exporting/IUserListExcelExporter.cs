using System.Collections.Generic;
using Helios.Authorization.Users.Dto;
using Helios.Dto;

namespace Helios.Authorization.Users.Exporting
{
    public interface IUserListExcelExporter
    {
        FileDto ExportToFile(List<UserListDto> userListDtos);
    }
}