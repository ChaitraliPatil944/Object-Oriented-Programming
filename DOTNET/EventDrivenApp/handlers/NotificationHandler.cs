
public class NotificatonManager{

    public void SendEmail(string message){
        Console.WriteLine($"Email sent with message: {message}");
    }

    public void SendSMS(string message){
        Console.WriteLine($"SMS sent with message: {message}");
    }

    public void WhatsappMessage(string message){
        Console.WriteLine($"WhatsApp message sent with message: {message}");
    }
}