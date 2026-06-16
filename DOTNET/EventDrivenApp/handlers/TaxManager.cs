namespace Taxation;
using Handlers;

public class TaxManager{

    //event handling logic
    public void PayIncomeTax(double amount){
        double calculatedTax = amount * 0.3; // Assuming a flat tax rate of 30%
        Console.WriteLine($"Income tax of {calculatedTax} paid on amount: {amount }");
    }

    public void BlockAccount(double amount){
        double fine =5000;
        Console.WriteLine($"Account blocked due to high balance of {amount}");
        Console.WriteLine($"Fine of {fine} imposed on the account");
    }

}