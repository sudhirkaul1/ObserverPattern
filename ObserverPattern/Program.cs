// See https://aka.ms/new-console-template for more information
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ObserverPattern.Application;
using ObserverPattern.Customer;
using ObserverPattern.Subject;

Console.WriteLine("Hello, World!");

IHost _host = Host.CreateDefaultBuilder().ConfigureServices(services =>
{
    services.AddSingleton<IOrderStatus,OrderStatus>();
    //services.AddSingleton<IOrderStatusObservers,IOrderStatusObservers>();
    services.AddSingleton<IOnline, Online>();
    services.AddSingleton<IWalkin, Walkin>();
    services.AddSingleton<IDriveAway,DriveAway>();
    services.AddSingleton<IApplication, Application>();
    
}).Build();

var app = _host.Services.GetRequiredService<IApplication>();
app.Run();


