using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using SchoolManegment.EntityFrameworkCore;
using SchoolManegment.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace SchoolManegment.Web.Tests
{
    [DependsOn(
        typeof(SchoolManegmentWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class SchoolManegmentWebTestModule : AbpModule
    {
        public SchoolManegmentWebTestModule(SchoolManegmentEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(SchoolManegmentWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(SchoolManegmentWebMvcModule).Assembly);
        }
    }
}