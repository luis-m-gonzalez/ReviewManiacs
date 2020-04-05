using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ReviewManiacs.Configuration;
using ReviewManiacs.Web;

namespace ReviewManiacs.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ReviewManiacsDbContextFactory : IDesignTimeDbContextFactory<ReviewManiacsDbContext>
    {
        public ReviewManiacsDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ReviewManiacsDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ReviewManiacsDbContextConfigurer.Configure(builder, configuration.GetConnectionString(ReviewManiacsConsts.ConnectionStringName));

            return new ReviewManiacsDbContext(builder.Options);
        }
    }
}
