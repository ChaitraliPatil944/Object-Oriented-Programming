namespace TFLBank.service;

class SMSService : INotificationService{

    void send (string msg){
        Console.WriteLine("SMS sent successfully" + msg);
    }
}