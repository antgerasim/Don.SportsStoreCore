using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.MicroKernel.Registration;
using Microsoft.Extensions.Configuration;
using Don.SportsStoreCore.Configuration;
using Don.SportsStoreCore.EntityFrameworkCore;
using Don.SportsStoreCore.Migrator.DependencyInjection;

namespace Don.SportsStoreCore.Migrator
{
    [DependsOn(typeof(SportsStoreCoreEntityFrameworkModule))]
    public class SportsStoreCoreMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public SportsStoreCoreMigratorModule(SportsStoreCoreEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(SportsStoreCoreMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                SportsStoreCoreConsts.ConnectionStringName
                );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(typeof(IEventBus), () =>
            {
                IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                );
            });
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SportsStoreCoreMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}