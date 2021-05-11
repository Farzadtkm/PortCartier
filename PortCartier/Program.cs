using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using PortCartier.Data;
using PortCartier.Models.Entities;
using System;
using System.Threading.Tasks;

namespace PortCartier
{
    public class Program
    {
        public async static Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();

            using var scope = host.Services.CreateScope();

            var services = scope.ServiceProvider;

            try
            {
                var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

                var userManager = services.GetRequiredService<UserManager<ApplicationUser>>();

                await ApplicationDbContextSeed.SeedDefaultRolesAsync(roleManager);

                await ApplicationDbContextSeed.SeedDefaultAdministratorAsync(userManager);
            }
            catch (Exception exception)
            {
                var logger = scope.ServiceProvider.GetRequiredService<ILogger<Program>>();

                logger.LogError(exception, "an error occurred while seeding the database");

                throw;
            }

            await host.RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}