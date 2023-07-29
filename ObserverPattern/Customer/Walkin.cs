using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Customer;
public class Walkin : IWalkin, IOrderStatusObservers
{
    private readonly IOrderStatus _orderStatus;
    public Walkin(IOrderStatus orderStatus)
    {
        _orderStatus = orderStatus;
        orderStatus.Add(this);
    }
    public void UnSubscribe()
    {
        _orderStatus.Remove(this);
    }
    public void Notify()
    {
        Console.WriteLine("Walkin Order Status");
    }
}
