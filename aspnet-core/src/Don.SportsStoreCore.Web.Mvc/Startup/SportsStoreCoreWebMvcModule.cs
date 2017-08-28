using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.SportsStoreCore.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Don.SportsStoreCore.Web.Startup
{
    [DependsOn(typeof(SportsStoreCoreWebCoreModule))]
    public class SportsStoreCoreWebMvcModule : AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SportsStoreCoreWebMvcModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void PreInitialize()
        {
            Configuration.Navigation.Providers.Add<SportsStoreCoreNavigationProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SportsStoreCoreWebMvcModule).GetAssembly());
        }
    }
}