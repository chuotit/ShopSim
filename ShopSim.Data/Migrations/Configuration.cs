namespace ShopSim.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using ShopSim.Model.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<ShopSim.Data.ShopSimDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ShopSim.Data.ShopSimDbContext context)
        {
            var manager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ShopSimDbContext()));

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ShopSimDbContext()));

            var user = new ApplicationUser()
            {
                UserName = "tiencong",
                Email = "tiencong.com@gmail.com",
                EmailConfirmed = true,
                BirthDay = DateTime.Now,
                FullName = "Tiến Công"

            };

            manager.Create(user, "a123456");

            if (!roleManager.Roles.Any())
            {
                roleManager.Create(new IdentityRole { Name = "Admin" });
                roleManager.Create(new IdentityRole { Name = "User" });
            }

            var adminUser = manager.FindByEmail("tiencong.com@gmail.com");

            manager.AddToRoles(adminUser.Id, new string[] { "Admin", "User" });
        }
    }
}
