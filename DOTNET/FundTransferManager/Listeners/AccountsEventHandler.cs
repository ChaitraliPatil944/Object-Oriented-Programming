namespace FundTransfer.Listener
{
    public class AccountEventHandler : IAccountListener
    {
        public void OnUnderBalance(double balance)
        {
            Console.WriteLine("Amount is less than  minimum balance policy");
        }

        public void OnOverBalance(double balance)
        {
            Console.WriteLine("Amount is greater than  Taxable income policy");
        }
    }
}