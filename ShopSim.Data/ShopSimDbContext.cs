using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;
using ShopSim.Model.Models;

namespace ShopSim.Data
{
    public class ShopSimDbContext : IdentityDbContext<ApplicationUser>
    {
        public ShopSimDbContext() : base("ShopSimConnect")
        {
            // Cài đặt để khi incluce bảng cha thì tự động include luôn bảng con của nó.
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<SimNetwork> SimNetworks { set; get; }
        public DbSet<FirstNumber> FirstNumbers { set; get; }
        public DbSet<Error> Errors { set; get; }

        public static ShopSimDbContext Create()
        {
            return new ShopSimDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder builder)
        {
            builder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId });
            builder.Entity<IdentityUserLogin>().HasKey(i => i.UserId);
        }
    }
}