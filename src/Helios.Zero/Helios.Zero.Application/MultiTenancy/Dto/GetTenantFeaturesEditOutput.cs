using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Helios.Zero.Editions.Dto;

namespace Helios.Zero.MultiTenancy.Dto
{
    public class GetTenantFeaturesEditOutput
    {
        public List<NameValueDto> FeatureValues { get; set; }

        public List<FlatFeatureDto> Features { get; set; }
    }
}