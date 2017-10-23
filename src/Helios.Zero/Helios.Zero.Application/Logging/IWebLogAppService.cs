using Abp.Application.Services;
using Helios.Zero.Dto;
using Helios.Zero.Logging.Dto;

namespace Helios.Zero.Logging
{
    public interface IWebLogAppService : IApplicationService
    {
        GetLatestWebLogsOutput GetLatestWebLogs();

        FileDto DownloadWebLogs();
    }
}
