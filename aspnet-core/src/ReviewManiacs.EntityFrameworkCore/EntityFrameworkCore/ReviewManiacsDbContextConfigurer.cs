using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ReviewManiacs.EntityFrameworkCore
{
    public static class ReviewManiacsDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ReviewManiacsDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ReviewManiacsDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
