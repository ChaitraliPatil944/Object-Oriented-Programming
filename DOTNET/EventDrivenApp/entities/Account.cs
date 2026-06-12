namespace Banking;
using Handlers;

public class Account{

    public double Balance { get; set;}

    public event Sender notify;

    public void withdraw(double amount){
        double calculatedResult=this.Balnce + amount;
        notify.Invoke("Amount withdrawn successfully"); 
    }

    public void deposit(double amount){
        double calculatedResult=this.Balnce - amount; 
        notify.Invoke("Amount deposited successfully");
    }
}