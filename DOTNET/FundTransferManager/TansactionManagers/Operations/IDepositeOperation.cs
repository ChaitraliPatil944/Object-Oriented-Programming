namespace FundTransfer.TransactionManager.operations
{
    public interface IDepositeOperation
    {
        bool Deposite(string accountid,double amount);
    }
}