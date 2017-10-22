using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Editions.Dto;
using Helios.MultiTenancy.Dto;

// ReSharper disable once CheckNamespace
namespace Helios.MultiTenancy
{
    /// <summary>
    /// 租户注册应用服务接口，用于接待租户注册相关业务
    /// </summary>
    public partial interface ITenantRegistrationAppService: IApplicationService
    {
        /// <summary>
        /// 建立新租户，开启一个新的租户
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}