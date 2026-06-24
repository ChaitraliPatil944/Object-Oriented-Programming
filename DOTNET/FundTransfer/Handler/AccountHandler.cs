namespace TFLBank.Handler;
using TFLBank.model; 

public class AccountHandler : IAccountHandler{
    public void onUnderBalance (Account acct)
    {
        Console.WriteLine("ammount is less than minimun balance policy");

    }
    public void onOverBalance (Account acct){
        Console.WriteLine("ammount is less than minimun balance policy");
    }
}