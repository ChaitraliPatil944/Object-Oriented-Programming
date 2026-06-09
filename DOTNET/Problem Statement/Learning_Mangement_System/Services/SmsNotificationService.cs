using System;

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("SMS SENT");
        Console.WriteLine(message);
    }
}