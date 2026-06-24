using FundTransfer.models;

namespace FundTransfer.TransactionManager.operations
{
    public interface IFundTransferOperation
    {
        bool TranferFund(string fromAccount, string toAccount, double amount);
    }
}