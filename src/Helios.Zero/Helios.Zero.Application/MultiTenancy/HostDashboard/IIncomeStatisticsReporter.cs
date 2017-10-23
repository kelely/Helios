using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Helios.Zero.MultiTenancy.HostDashboard.Dto;

namespace Helios.Zero.MultiTenancy.HostDashboard
{
    public interface IIncomeStatisticsService
    {
        Task<List<IncomeStastistic>> GetIncomeStatisticsData(DateTime startDate, DateTime endDate,
            ChartDateInterval dateInterval);
    }
}