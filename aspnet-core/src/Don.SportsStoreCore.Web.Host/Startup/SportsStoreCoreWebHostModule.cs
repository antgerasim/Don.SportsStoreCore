using System.Reflection;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Don.SportsStoreCore.Configuration;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;

namespace Don.SportsStoreCore.Web.Host.Startup
{
    [DependsOn(
       typeof(SportsStoreCoreWebCoreModule))]
    public class SportsStoreCoreWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SportsStoreCoreWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SportsStoreCoreWebHostModule).GetAssembly());
        }
    }
}
