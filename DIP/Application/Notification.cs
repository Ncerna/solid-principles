using DIP.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DIP.application
{
    // DIP: High-level module (Notification)
    // It does NOT depend on concrete implementations like EmailService or SmsService
    // It depends on the abstraction (IMessageService)

    public class Notification
    {
        private IMessageService _messageService;

        // DIP: Dependency is inverted by depending on an interface
        // The concrete implementation is provided from outside
        public Notification(IMessageService messageService)
        {
            _messageService = messageService;
        }

        public void Notify(string message)
        {
            // DIP: Delegates the behavior to the abstraction
            _messageService.Send(message);
        }
    }
}
