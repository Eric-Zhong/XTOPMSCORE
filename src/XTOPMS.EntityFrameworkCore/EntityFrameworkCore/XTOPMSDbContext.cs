using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using XTOPMS.Authorization.Roles;
using XTOPMS.Authorization.Users;
using XTOPMS.MultiTenancy;

namespace XTOPMS.EntityFrameworkCore
{
    public class XTOPMSDbContext : AbpZeroDbContext<Tenant, Role, User, XTOPMSDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public XTOPMSDbContext(DbContextOptions<XTOPMSDbContext> options)
            : base(options)
        {
        }
    }
}
