using CmsDemo.Core.Dependency;
using CmsDemo.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace CmsDemo.EntityFrameWorkCore
{
    public class CmsDemoDbContext : DbContext, ITransientDependency
    {
        public CmsDemoDbContext(DbContextOptions<CmsDemoDbContext> options)
            : base(options)
        {

        }
        public DbSet<Admin> Admin { get; set; }

        public DbSet<Role> Role { get; set; }

        public DbSet<Permission> Permission { get; set; }

        public DbSet<RolePermission> RolePermission { get; set; }

    }
}
