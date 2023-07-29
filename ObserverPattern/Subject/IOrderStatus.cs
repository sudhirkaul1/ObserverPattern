using ObserverPattern.Customer;

namespace ObserverPattern.Subject
{
    public interface IOrderStatus
    {
        void Add(IOrderStatusObservers orderStatusObservers);
        void NotifyOrderStatus();
        void Remove(IOrderStatusObservers orderStatusObservers);
    }
}