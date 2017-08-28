using Abp.MultiTenancy;
using Don.SportsStoreCore.Authorization.Users;

namespace Don.SportsStoreCore.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {
            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}