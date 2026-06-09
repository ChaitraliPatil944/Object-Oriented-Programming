namespace LMSAPP.Messaging;

public class SmsNotificationService : INotificationService
{
    public void SendNotification(string message, string recipient)
    {
        // Simulate sending an SMS notification.
        Console.WriteLine($"SMS sent to {recipient}: {message}");
    }

}