using Microsoft.Extensions.DependencyInjection;

namespace ZNO.Front.ViewModel.Locator
{
    public class ViewModelLocator
    {
        public MainMenuModel MainMenuModel => App.AppHost!.Services.GetRequiredService<MainMenuModel>();
        public MenuAlgebraViewModel MenuAlgebraModel => App.AppHost!.Services.GetRequiredService<MenuAlgebraViewModel>();
        public MenuGeometryViewModel MenuGeometryModel => App.AppHost!.Services.GetRequiredService<MenuGeometryViewModel>();
        public AboutDevViewModel AboutDevViewModel  => App.AppHost!.Services.GetRequiredService<AboutDevViewModel>();
        public TestViewModel TestViewModel => App.AppHost!.Services.GetRequiredService<TestViewModel>();
        public StatisticsViewModel StatisticsViewModel => App.AppHost!.Services.GetRequiredService<StatisticsViewModel>();
        public HomeViewModel HomeViewModel => App.AppHost!.Services.GetRequiredService<HomeViewModel>();

    }
}
