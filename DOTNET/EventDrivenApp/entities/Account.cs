namespace Banking;
using Handlers;

public class Account{
    //business logic
    public double Balance { get; set;}

    public event Sender? notify ;  //event declaration, Sender is a delegate type defined in Handlers namespace, notify is the name of the event. This event can be triggered to send notifications when certain actions occur on the Account class, such as deposits or withdrawals.
    public event TaxInspector? overBalance;

    public void withdraw(double amount){
        double calculatedResult=this.Balance - amount;
        notify?.Invoke("Amount withdrawn successfully");  //? is used to check if the event has any subscribers before invoking it, preventing a NullReferenceException if there are no subscribers.
    }

    public void deposit(double amount){
        double calculatedResult=this.Balance + amount; 
        notify?.Invoke("Amount deposited successfully"); //notify is invoked to send a notification message when a deposit is made, indicating that the amount was deposited successfully.
        if (calculatedResult > 100000){
            overBalance?.Invoke(calculatedResult);
        }
 
    }
}