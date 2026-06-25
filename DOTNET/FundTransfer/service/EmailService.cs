namespace TFLBank.service;

class EmailService : INotificationService{

    public void send (string msg){
        Console.WriteLine("Email sent successfully" + msg);
    }
}