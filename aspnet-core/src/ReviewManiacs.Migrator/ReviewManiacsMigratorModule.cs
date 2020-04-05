using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReviewManiacs.Configuration;
using ReviewManiacs.EntityFrameworkCore;
using ReviewManiacs.Migrator.DependencyInjection;

namespace ReviewManiacs.Migrator
{
    [DependsOn(typeof(ReviewManiacsEntityFrameworkModule))]
    public class ReviewManiacsMigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ReviewManiacsMigratorModule(ReviewManiacsEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ReviewManiacsMigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ReviewManiacsConsts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReviewManiacsMigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
