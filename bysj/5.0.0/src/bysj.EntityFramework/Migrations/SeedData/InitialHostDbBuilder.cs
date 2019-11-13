using bysj.EntityFramework;
using EntityFramework.DynamicFilters;

namespace bysj.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly bysjDbContext _context;

        public InitialHostDbBuilder(bysjDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
