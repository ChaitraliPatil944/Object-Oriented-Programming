using System;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message)
    {
        Console.WriteLine("EMAIL SENT");
        Console.WriteLine(message);
    }
}