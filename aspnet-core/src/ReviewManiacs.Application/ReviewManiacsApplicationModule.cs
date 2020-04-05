using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReviewManiacs.Authorization;

namespace ReviewManiacs
{
    [DependsOn(
        typeof(ReviewManiacsCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ReviewManiacsApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ReviewManiacsAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ReviewManiacsApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
