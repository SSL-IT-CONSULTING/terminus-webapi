
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using terminus_webapi.Entities;

namespace terminus_webapi.Data
{
    public class AppDBContext:IdentityDbContext<TerminusAppUser, TerminusAppRole, string>
    {
        public AppDBContext(DbContextOptions<AppDBContext> options):base(options)
        {

        }

        public DbSet<Company> Companies { get; set; }
        public DbSet<Tenant> Tenants { get; set; }
        public DbSet<Transaction> Transactions { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Revenue> Revenues { get; set; }
        public DbSet<Property> Properties { get; set; }
 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            //as
        }
 

        public DbSet<terminus_webapi.Entities.TenantProperty> TenantProperty { get; set; }
 

        public DbSet<terminus_webapi.Entities.Vendor> Vendor { get; set; }
 

        public DbSet<terminus_webapi.Entities.User> User { get; set; }
    }
}