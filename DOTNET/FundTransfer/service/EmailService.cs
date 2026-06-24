namespace TFLBank.service;

class EmailService : INotificationService{

    void send (string msg){
        Console.WriteLine("Email sent successfully" + msg);
    }
}