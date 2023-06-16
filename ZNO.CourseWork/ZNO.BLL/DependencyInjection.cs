using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using ZNO.BLL.Profiles;
using ZNO.BLL.Services;
using ZNO.BLL.Services.Interface;
using ZNO.DAL;
using ZNO.DAL.Repositories.Interface;

namespace ZNO.BLL
{
    public static class DependencyInjection
    {
        public static void AddZNOServices(this IServiceCollection services, IMapperConfigurationExpression mapConfigExpression, string connectionString)
        {
            mapConfigExpression.AddProfile<AutoMapping>();
            services.AddTransient<IZmistService, ZmistService>();
            services.AddTransient<ITopicService, TopicService>();
            services.AddTransient<ITimeService, TimeService>();
            services.AddDALServices(connectionString);
        }
    }
}
