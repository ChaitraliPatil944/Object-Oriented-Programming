namespace Banking
using Handlers;
{
    public class Program{
        public static void Main(string[] args)
        {
           NotificatonManager notificationManager = new NotificatonManager();
              Account account123 = new Account();
              account123.notify += notificationManager.SendEmail;  //subscribing to the event / attaching the event handler
              account123.Balance = 89000;
              account123.withdraw(5000);
        }
    }
}