using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolManegment.Configuration;

namespace SchoolManegment.Web.Host.Startup
{
    [DependsOn(
       typeof(SchoolManegmentWebCoreModule))]
    public class SchoolManegmentWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public SchoolManegmentWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolManegmentWebHostModule).GetAssembly());
        }
    }
}
