using Microsoft.EntityFrameworkCore;
using IsmtJobportal.Entities;

namespace IsmtJobPorter
{
    public class JobPortalDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public string DbPath { get; }

        public JobPortalDbContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "ISMTjobportar.db");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlite($"Data Source={DbPath}");
        }
    }
}