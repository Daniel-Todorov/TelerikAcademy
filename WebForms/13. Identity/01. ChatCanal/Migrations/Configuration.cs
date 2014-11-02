namespace _01.ChatCanal.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using _01.ChatCanal.Models;
    using Microsoft.AspNet.Identity.EntityFramework;
    using System.Web.Security;
    using Microsoft.AspNet.Identity;
    using Microsoft.Ajax.Utilities;

    internal sealed class Configuration : DbMigrationsConfiguration<_01.ChatCanal.Models.ChatCanelContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(_01.ChatCanal.Models.ChatCanelContext context)
        {
            var moderatorRole = new IdentityRole("Moderator");
            context.Roles.AddOrUpdate(moderatorRole);

            var adminRole = new IdentityRole("Admin");
            context.Roles.AddOrUpdate(adminRole);

            context.SaveChanges();

            var adminUser = new ApplicationUser()
            {
                FirstName = "Pesho",
                LastName = "Peshev",
                Email = "admin@abv.bg",
                UserName = "admin@abv.bg",
            };
            var moderatorUser = new ApplicationUser()
            {
                FirstName = "Gosho",
                LastName = "Goshev",
                Email = "moderator@abv.bg",
                UserName = "moderator@abv.bg",
            };




            var applicationUserManager = new ApplicationUserManager(new UserStore<ApplicationUser>(context));

            var result = applicationUserManager.Create(adminUser, "123456");

            if (!result.Succeeded)
            {
                throw new Exception();
            }

            result = applicationUserManager.Create(moderatorUser, "123456");

            if (!result.Succeeded)
            {
                throw new Exception();
            }

            context.SaveChanges();




            //context.Users.AddOrUpdate(adminUser);
            //context.Users.AddOrUpdate(moderatorUser);

            adminUser.Roles.Add(new IdentityUserRole() { UserId = adminUser.Id, RoleId = adminRole.Id });
            adminUser.Roles.Add(new IdentityUserRole() { UserId = adminUser.Id, RoleId = moderatorRole.Id });
            moderatorUser.Roles.Add(new IdentityUserRole() { UserId = moderatorUser.Id, RoleId = moderatorRole.Id });

            context.SaveChanges();
        }
    }
}
