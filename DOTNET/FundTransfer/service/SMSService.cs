namespace TFLBank.service;

class SMSService : INotificationService{

    public void send (string msg){
        Console.WriteLine("SMS sent successfully" + msg);
    }
}