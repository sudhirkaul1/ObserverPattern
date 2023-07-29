using Microsoft.Extensions.Logging;
using ObserverPattern.Customer;
using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Application;
public class Application : IApplication
{
    private readonly ILogger _logger;
    private readonly IOrderStatus _orderStatus;
    private readonly IDriveAway _driveAway;
    private readonly IOnline _online;
    private readonly IWalkin _walkin;

    public Application(
        ILogger<Application> logger,
        IOnline online,
        IWalkin walkin,
        IDriveAway driveAway,
        IOrderStatus orderStatus)
    {
        _logger = logger;
        _online = online;
        _walkin = walkin;
        _driveAway = driveAway;
        _orderStatus = orderStatus;
    }
    public void Run()
    {
        _logger.Log(LogLevel.Information, "Application Started");
        _orderStatus.NotifyOrderStatus();
        Console.WriteLine("----------------");
        _driveAway.UnSubscribe();
        _orderStatus.NotifyOrderStatus();
        Console.WriteLine("--------------");
        _online.UnSubscribe();

        _orderStatus.NotifyOrderStatus();

        Console.WriteLine("-----------------");
        _walkin.UnSubscribe();
        _orderStatus.NotifyOrderStatus();
        
    }
}
