using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ShopSim.Model.Models;

namespace ShopSim.Data
{
    public class ShopSimDbContext: DbContext
    {
        public ShopSimDbContext() : base("ShopSimConnect")
        {
            // Cài đặt để khi incluce bảng cha thì tự động include luôn bảng con của nó.
            this.Configuration.LazyLoadingEnabled = false;
        }

        public DbSet<SimNetwork> SimNetworks { set; get; }
        public DbSet<FirstNumber> FirstNumbers { set; get; }
        public DbSet<Error> Errors { set; get; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
        }
    }
}
