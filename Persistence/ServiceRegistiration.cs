using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Persistence.AppDbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public static class ServiceRegistiration
    {
        public static void AddPersistenceLayer(this IServiceCollection service, IConfiguration configuration)
        {
            service.AddDbContext<ThreadlyDbContext>(options =>
            {
                options.UseNpgsql(configuration.GetConnectionString("DbPostgres"));
            });
        }

    }
}
