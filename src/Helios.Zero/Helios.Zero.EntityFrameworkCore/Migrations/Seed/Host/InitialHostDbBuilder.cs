using Helios.Zero.EntityFrameworkCore;

namespace Helios.Zero.Migrations.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly HeliosZeroDbContext _context;

        public InitialHostDbBuilder(HeliosZeroDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
