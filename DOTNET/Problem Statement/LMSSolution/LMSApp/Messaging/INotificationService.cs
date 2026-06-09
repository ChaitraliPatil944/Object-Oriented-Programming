namespace LMSAPP.Messaging;
public interface INotificationService
{
    void SendNotification(string message, string recipient);
}