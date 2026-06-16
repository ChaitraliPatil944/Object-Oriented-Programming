namespace Banking;
using Handlers;
using Taxation;

    public class Program{
        public static void Main(string[] args)
        {
           NotificatonManager notificationManager = new NotificatonManager();
              Account account123 = new Account();
              TaxManager taxManager = new TaxManager(); // Create an instance of TaxManager to handle tax-related operations.

              //Orchestration logic
              account123.notify += notificationManager.SendEmail;  //subscribing to the event / attaching the event handler
              account123.notify += notificationManager.SendSMS;  //+= operator is used to subscribe the SendSMS method to the notify event, allowing it to be called when the event is triggered.
              account123.notify += notificationManager.WhatsappMessage;  

              account123.overBalance += taxManager.PayIncomeTax; // Subscribing the PayIncomeTax method to the overBalance event, so that it will be called when the event is triggered.
              account123.overBalance += taxManager.BlockAccount; // Subscribing the BlockAccount method to the overBalance event, so that it will be called when the event is triggered.
              account123.Balance = 89000;
              //account123.withdraw(5000);
               account123.deposit(300000);
            //   account123.withdraw(2000);

        }
    }
