namespace LMSAPP.Messaging;

public class EmailNotificationService : INotificationService
{
    public void SendNotification(string message, string recipient)
    {
        // Simulate sending an email notification.
        Console.WriteLine($"Email sent to {recipient}: {message}");
    }
}