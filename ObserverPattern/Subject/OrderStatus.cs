using ObserverPattern.Customer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Subject;
public class OrderStatus : IOrderStatus
{
    List<IOrderStatusObservers> orderStatusObserver = new List<IOrderStatusObservers> { };
    public void Add(IOrderStatusObservers orderStatusObservers)
    {
        orderStatusObserver.Add(orderStatusObservers);
    }
    public void Remove(IOrderStatusObservers orderStatusObservers)
    {
        orderStatusObserver.Remove(orderStatusObservers);
    }
    public void NotifyOrderStatus()
    {
        foreach (var observer in orderStatusObserver)
        {
            observer.Notify();
        }
    }

    
}
