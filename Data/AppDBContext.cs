
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

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }
    }
}