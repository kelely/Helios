using System.Collections.Generic;
using Helios.Zero.Auditing.Dto;
using Helios.Zero.Dto;

namespace Helios.Zero.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
