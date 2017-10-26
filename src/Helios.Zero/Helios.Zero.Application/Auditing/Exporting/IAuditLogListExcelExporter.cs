using System.Collections.Generic;
using Helios.Auditing.Dto;
using Helios.Dto;

namespace Helios.Auditing.Exporting
{
    public interface IAuditLogListExcelExporter
    {
        FileDto ExportToFile(List<AuditLogListDto> auditLogListDtos);
    }
}
