using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using StarTEDSystem.BLL;
using StarTEDSystem.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarTEDSystem
{
    public static class StartUpExtension
    {
        public static void AddBackendDependencies(this IServiceCollection services, Action<DbContextOptionsBuilder> options)
        {
            services.AddDbContext<StartedContext>(options);

            services.AddTransient<StarTEDServices>((serviceProvider) =>
            {
                var context = serviceProvider.GetRequiredService<StartedContext>();
                return new StarTEDServices(context);
            });
        }
    }
}
