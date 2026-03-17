using DIP.application;
using DIP.Implementation;
Console.WriteLine("The behavior does NOT change when called" +
    " It remains fixed as long as the object lives");

// DIP: Injecting EmailService as the concrete implementation
var notification = new Notification(new EmailService());
notification.Notify("Hello");

// DIP: Switching to another implementation without modifying Notification
var notification2 = new Notification(new SmsService());
notification2.Notify("Hello");