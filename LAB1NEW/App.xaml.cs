using LAB1NEW.Repository;
using LAB1NEW;
using Microsoft.Extensions.DependencyInjection;
using System.Configuration;
using System.Data;
using System.Windows;

namespace LAB1NEW
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private ServiceProvider serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigurationServices(services);
            serviceProvider = services.BuildServiceProvider();
        }

        private void ConfigurationServices(ServiceCollection services)
        {
            services.AddSingleton(typeof(ICarRepository), typeof(CarRepository));
            services.AddSingleton<MainWindow>();
        }
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var windowCarManagement = serviceProvider.GetService<MainWindow>();
            MainWindow.Show();
        }
    }

}
