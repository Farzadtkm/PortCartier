using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(PortCartier.Areas.Identity.IdentityHostingStartup))]
namespace PortCartier.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}