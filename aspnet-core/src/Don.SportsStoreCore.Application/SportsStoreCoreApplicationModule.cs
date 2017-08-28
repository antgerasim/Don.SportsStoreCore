using System.Reflection;
using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.SportsStoreCore.Authorization;

namespace Don.SportsStoreCore
{
    [DependsOn(
        typeof(SportsStoreCoreCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SportsStoreCoreApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SportsStoreCoreAuthorizationProvider>();
        }

        public override void Initialize()
        {
            Assembly thisAssembly = typeof(SportsStoreCoreApplicationModule).GetAssembly();
            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(cfg =>
            {
                //Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg.AddProfiles(thisAssembly);
            });
        }
    }
}