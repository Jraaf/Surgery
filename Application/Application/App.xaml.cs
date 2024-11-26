using App.MVVM.View;
using Business.Services;
using Business.Services.Interfaces;
using DataAccess.EF;
using DataAccess.Repository;
using DataAccess.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Configuration;
using System.Data;
using System.Windows;

namespace Application
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : System.Windows.Application
    {
        private  IServiceProvider _serviceProvider;
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            var serviceCollection = new ServiceCollection();
            ConfigureServices(serviceCollection);

            _serviceProvider = serviceCollection.BuildServiceProvider();

            var mainWindow = _serviceProvider.GetRequiredService<MainWindow>();
            //mainWindow.Show();
        }
        private void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<OperationsDepartmentContext>(options =>
            {
                options.UseSqlServer("Server=DESKTOP-S7D9M3G\\SQLEXPRESS;Database=OPERATIONS_DEPARTMENT;Integrated Security=true;TrustServerCertificate=true;");
            });
            services.AddScoped<IMedicalCaseRepository, MedicalCaseRepository>();
            services.AddScoped<IMedicalCaseService, MedicalCaseService>();

            // Register services
            services.AddScoped<IMedicalCaseService, MedicalCaseService>();

            // Register windows
            services.AddScoped<HomeView>();
            services.AddTransient<AddMedicalCaseView>();
            services.AddTransient<MainWindow>();
        }
    }

}
