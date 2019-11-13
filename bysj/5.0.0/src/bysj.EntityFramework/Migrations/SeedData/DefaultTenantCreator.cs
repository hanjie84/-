using System.Linq;
using bysj.EntityFramework;
using bysj.MultiTenancy;

namespace bysj.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly bysjDbContext _context;

        public DefaultTenantCreator(bysjDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            CreateUserAndRoles();
        }

        private void CreateUserAndRoles()
        {
            //Default tenant

            var defaultTenant = _context.Tenants.FirstOrDefault(t => t.TenancyName == Tenant.DefaultTenantName);
            if (defaultTenant == null)
            {
                _context.Tenants.Add(new Tenant {TenancyName = Tenant.DefaultTenantName, Name = Tenant.DefaultTenantName});
                _context.SaveChanges();
            }
        }
    }
}
