using Abp.Zero.EntityFrameworkCore;
using Don.SportsStoreCore.Authorization.Roles;
using Don.SportsStoreCore.Authorization.Users;
using Don.SportsStoreCore.MultiTenancy;
using Microsoft.EntityFrameworkCore;

namespace Don.SportsStoreCore.EntityFrameworkCore
{
    public class SportsStoreCoreDbContext : AbpZeroDbContext<Tenant, Role, User, SportsStoreCoreDbContext>
    {
        /* Define an IDbSet for each entity of the application */
        
        public SportsStoreCoreDbContext(DbContextOptions<SportsStoreCoreDbContext> options)
            : base(options)
        {

        }
    }
}
