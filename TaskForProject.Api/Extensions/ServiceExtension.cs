using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TaskForProject.Api.Dbcontext;
using TaskForProject.Api.Repositories.IRepository;
using TaskForProject.Api.Repositories.Repository;
using TaskForProject.Api.Services.IServices;
using TaskForProject.Api.Services.Services;

namespace TaskForProject.Api.Extensions
{
    public static class ServiceExtension
    {

        public static void AddDbContextes(this IServiceCollection services,IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseNpgsql(configuration.GetConnectionString("DefaultConnection")));
        }


        public static void AddRepositorys(this IServiceCollection services)
        {
            services.AddTransient<IBook1Repository,Book1Repository>();
            services.AddTransient<IBook2Repository,Book2Repository>();
        }

        public static void AddServices(this IServiceCollection services)
        {
            services.AddTransient<IBook1Services,Book1Service>();   
            services.AddTransient<IBook2Service,Book2Service>();
        }
    }
}
