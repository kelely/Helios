using Abp.Application.Services;
using Helios.Dto;
using Helios.Logging.Dto;

namespace Helios.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
