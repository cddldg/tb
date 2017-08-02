using System.Linq;
using TB.EntityFramework;
using TB.MultiTenancy;

namespace TB.Migrations.SeedData
{
    public class DefaultTenantCreator
    {
        private readonly TBDbContext _context;

        public DefaultTenantCreator(TBDbContext context)
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
