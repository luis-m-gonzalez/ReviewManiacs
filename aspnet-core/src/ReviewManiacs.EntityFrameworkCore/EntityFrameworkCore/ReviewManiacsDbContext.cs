using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ReviewManiacs.Authorization.Roles;
using ReviewManiacs.Authorization.Users;
using ReviewManiacs.MultiTenancy;

namespace ReviewManiacs.EntityFrameworkCore
{
    public class ReviewManiacsDbContext : AbpZeroDbContext<Tenant, Role, User, ReviewManiacsDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public ReviewManiacsDbContext(DbContextOptions<ReviewManiacsDbContext> options)
            : base(options)
        {
        }
    }
}
