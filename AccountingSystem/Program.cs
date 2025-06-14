using AccountingSystem.Forms;
using AccountingSystem.Forms.Employees;
using Applications.Services;
using Domain.Interfaces.Repos;
using Domain.Interfaces.Services;
using Infrastructure;
using Infrastructure.Repos;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows.Forms;

namespace AccountingSystem
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            var host = CreateHostBuilder().Build();
            var serviceManager = host.Services.GetRequiredService<IServiceManager>();
            Application.Run(new Frm_Login(serviceManager));
        }


        static IHostBuilder CreateHostBuilder() =>
            Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false);
                })
                .ConfigureServices((context, services) =>
                {
                    IConfiguration config = context.Configuration;

                    services.AddDbContext<AppDbContext>(o => o.UseSqlServer(config.GetConnectionString("Constr")));
                    services.AddScoped<IUnitOfWork, UnitOfwork>();
                    services.AddScoped<IPasswordService, PasswordService>();
                    services.AddScoped<IServiceManager, ServiceManager>();
                    services.AddAutoMapper(typeof(Applications.MappingProfile));
                });
    }
}
