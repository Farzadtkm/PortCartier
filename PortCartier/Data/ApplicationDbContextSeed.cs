using Microsoft.AspNetCore.Identity;
using PortCartier.Models.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortCartier.Data
{
    public class ApplicationDbContextSeed
    {
        public static async Task SeedDefaultRolesAsync(RoleManager<IdentityRole> roleManager)
        {
            var roles = new List<string> { "Administrator", "Employee", "User" };

            foreach (var role in roles)
            {
                if (!await roleManager.RoleExistsAsync(role)) await roleManager.CreateAsync(new IdentityRole(role));
            }
        }

        public static async Task SeedDefaultAdministratorAsync(UserManager<ApplicationUser> userManager)
        {
            var administrator = new ApplicationUser { UserName = "admin", Email = "admin@email.com" };

            if (userManager.Users.All(model => model.UserName != administrator.UserName))
            {
                await userManager.CreateAsync(administrator, "Admin123@@@");

                await userManager.AddToRoleAsync(administrator, "Administrator");
            }
        }
    }
}