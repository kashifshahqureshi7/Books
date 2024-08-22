using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolManegment.Authorization;

namespace SchoolManegment
{
    [DependsOn(
        typeof(SchoolManegmentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class SchoolManegmentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<SchoolManegmentAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(SchoolManegmentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
