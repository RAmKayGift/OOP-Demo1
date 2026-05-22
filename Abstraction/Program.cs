using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    interface INotificationService
    {
        void Send(string recipient, string message);
    }

    //  class for Email notification
    class EmailNotificationService : INotificationService
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine("Email sent to " + recipient + ": " + message);
        }
    }

    // class for SMS notification
    class SmsNotificationService : INotificationService
    {
        public void Send(string recipient, string message)
        {
            Console.WriteLine("SMS sent to " + recipient + ": " + message);
        }
    }

    // Order class to send a notification.
    class OrderService
    {
        private INotificationService notificationService;

        public OrderService(INotificationService service)
        {
            notificationService = service;
        }

        public void PlaceOrder(string customer, string item)
        {
            Console.WriteLine("Order placed for " + item);

            notificationService.Send(customer, "Your order for " + item + " has been placed.");
        }
    }

    class Program
    {
        static void Main()
        {
            OrderService emailOrder = new OrderService(new EmailNotificationService());
            emailOrder.PlaceOrder("fulufhelogift@email.com", "Laptop");
            Console.WriteLine();

            OrderService smsOrder = new OrderService(new SmsNotificationService());
            smsOrder.PlaceOrder("0818666961", "Chips");
        }
    }
}
