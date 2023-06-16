using Microsoft.Extensions.DependencyInjection;
using ZNO.DAL.Interface;

namespace ZNO.DAL
{
    public static class DependencyInjection
    {
        public static void AddDALServices(this IServiceCollection services, string connectionString)
        {
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            services.AddSingleton(_ => new DBContext(connectionString));
        }
    }
}
