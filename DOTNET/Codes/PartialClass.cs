//developer A
public partial class BankAccount {
    public string accountNumber { get;  set; }
    public decimal balance { get; set;}
    public string accountHolderName { get; set; }

}
//developer B
public partial class BankAccount{
    

    public void Deposit(decimal amount){
        balance += amount;
    }
    public void Withdraw(decimal amount){
        if (amount <= balance){
            balance -= amount;
        }else{
            Console.WriteLine("Insufficient funds");
        }
    }
}

public class MainClass{
    public static void Main(string[] args){
        BankAccount acc= new BankAccount();
        acc.accountNumber = "123456789";
        acc.accountHolderName = "Chait";
        acc.balance = 5000;
        acc.Deposit(1000);
        Console.WriteLine($"Account Number: {acc.accountNumber}");

    }
}