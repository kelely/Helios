using System.Threading.Tasks;
using Abp.Application.Services;
using Helios.Editions.Dto;
using Helios.MultiTenancy.Dto;

// ReSharper disable once CheckNamespace
namespace Helios.MultiTenancy
{
    /// <summary>
    /// �⻧ע��Ӧ�÷���ӿڣ����ڽӴ��⻧ע�����ҵ��
    /// </summary>
    public partial interface ITenantRegistrationAppService: IApplicationService
    {
        /// <summary>
        /// �������⻧������һ���µ��⻧
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        Task<RegisterTenantOutput> RegisterTenant(RegisterTenantInput input);

        Task<EditionsSelectOutput> GetEditionsForSelect();

        Task<EditionSelectDto> GetEdition(int editionId);
    }
}