using AutoMapper;
using ZNO.Front.Map;
using ZNO.Front.View;
using ZNO.Front.ViewModel;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;
using ZNO.Front;
using ZNO.DAL;
using ZNO.BLL;
using ZNO.Front.Models;

namespace ZNO.Front
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }

        private const string _connectionDBName = "ZNOConnection";

        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    var mapperConfigExpression = new MapperConfigurationExpression();
                    mapperConfigExpression.AddProfile<MappingProfile>();

                    var dbConnectionString = GetConnectionStringByName(_connectionDBName);
                    if (dbConnectionString != null)
                    {
                        services.AddZNOServices(mapperConfigExpression, dbConnectionString);
                    }

                    services.AddSingleton<MainMenuModel>();
                    services.AddTransient<MenuAlgebraViewModel>();
                    services.AddTransient<MenuGeometryViewModel>();
                    services.AddTransient<AboutDevViewModel>();
                    services.AddTransient<TestViewModel>();
                    services.AddTransient<StatisticsViewModel>();
                    services.AddTransient<HomeViewModel>();
                    services.AddSingleton(new MapperConfiguration(mapperConfigExpression).CreateMapper());

                }).Build();

            

        }

        void App_Startup(object sender, StartupEventArgs e)
        {
            var startupForm = new MainMenuWindow();
            Current.MainWindow = startupForm;
            Current.MainWindow.Show();

            
        }

        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();

            base.OnStartup(e);
        }

        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();

            base.OnExit(e);
        }

        private string GetConnectionStringByName(string name)
        {
            if (name == null)
            {
                throw new ArgumentNullException();
            }

            return System.Configuration.ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
