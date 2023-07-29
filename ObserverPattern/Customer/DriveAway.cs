﻿using ObserverPattern.Subject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Customer
{
    public class DriveAway : IDriveAway, IOrderStatusObservers
    {
        private readonly IOrderStatus _orderStatus;
        public DriveAway(IOrderStatus orderStatus)
        {
            _orderStatus = orderStatus;
            _orderStatus.Add(this);
        }

        public void UnSubscribe()
        {
            _orderStatus.Remove(this);
        }
        public void Notify()
        {
            Console.WriteLine("Drive Away notified");
        }
    }
}
