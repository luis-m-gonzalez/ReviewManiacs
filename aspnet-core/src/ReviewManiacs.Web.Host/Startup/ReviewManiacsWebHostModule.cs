using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ReviewManiacs.Configuration;

namespace ReviewManiacs.Web.Host.Startup
{
    [DependsOn(
       typeof(ReviewManiacsWebCoreModule))]
    public class ReviewManiacsWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ReviewManiacsWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ReviewManiacsWebHostModule).GetAssembly());
        }
    }
}
