using Helios.EntityFrameworkCore;

namespace Helios.Application.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly HeliosZeroDbContext _context;
        private readonly int _tenantId;

        public TestDataBuilder(HeliosZeroDbContext context, int tenantId)
        {
            _context = context;
            _tenantId = tenantId;
        }

        public void Create()
        {
            new TestOrganizationUnitsBuilder(_context, _tenantId).Create();
            new TestSubscriptionPaymentBuilder(_context, _tenantId).Create();

            _context.SaveChanges();
        }
    }
}
