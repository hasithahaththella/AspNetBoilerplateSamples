using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using AcmeCorp.Authorization.Roles;
using AcmeCorp.Authorization.Users;
using AcmeCorp.MultiTenancy;

namespace AcmeCorp.EntityFrameworkCore
{
    public class AcmeCorpDbContext : AbpZeroDbContext<Tenant, Role, User, AcmeCorpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public AcmeCorpDbContext(DbContextOptions<AcmeCorpDbContext> options)
            : base(options)
        {
        }
    }
}
