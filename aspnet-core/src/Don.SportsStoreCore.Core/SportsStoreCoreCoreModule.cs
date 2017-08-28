using Abp.Modules;
using Abp.Reflection.Extensions;
using Abp.Timing;
using Abp.Zero;
using Don.SportsStoreCore.Localization;
using Abp.Zero.Configuration;
using Don.SportsStoreCore.MultiTenancy;
using Don.SportsStoreCore.Authorization.Roles;
using Don.SportsStoreCore.Authorization.Users;
using Don.SportsStoreCore.Configuration;
using Don.SportsStoreCore.Timing;

namespace Don.SportsStoreCore
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class SportsStoreCoreCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            SportsStoreCoreLocalizationConfigurer.Configure(Configuration.Localization);

            //Enable this line to create a multi-tenant application.
            Configuration.MultiTenancy.IsEnabled = SportsStoreCoreConsts.MultiTenancyEnabled;

            //Configure roles
            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SportsStoreCoreCoreModule).GetAssembly());
        }

        public override void PostInitialize()
        {
            IocManager.Resolve<AppTimes>().StartupTime = Clock.Now;
        }
    }
}