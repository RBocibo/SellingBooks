using Microsoft.EntityFrameworkCore;
using SellingBooks.Infrastructure.Data;

namespace SellingBooks.API.Extensions
{
    public static class DatabaseConfigurations
    {
        public static void RegisterDb(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<SellingBooksDatabaseContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("SellingBooksConnectionStr"));
            });
        }
    }
}
