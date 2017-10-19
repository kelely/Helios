using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Helios.MultiTenancy.HostDashboard.Dto;

namespace Helios.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}