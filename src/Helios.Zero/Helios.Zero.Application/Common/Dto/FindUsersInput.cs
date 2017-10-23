using Helios.Zero.Dto;

namespace Helios.Zero.Common.Dto
{
    public class FindUsersInput : PagedAndFilteredInputDto
    {
        public int? TenantId { get; set; }
    }
}