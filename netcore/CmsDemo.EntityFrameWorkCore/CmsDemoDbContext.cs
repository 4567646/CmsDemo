using CmsDemo.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace CmsDemo.EntityFrameWorkCore
{
    public class CmsDemoDbContext : DbContext
    {
        public CmsDemoDbContext(DbContextOptions<CmsDemoDbContext> options)
            : base(options)
        {

        }
        public DbSet<Admin> Admin { get; set; }

    }
}
