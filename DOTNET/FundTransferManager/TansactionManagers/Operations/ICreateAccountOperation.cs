using FundTransfer.models;

namespace FundTransfer.TransactionManager.operations
{
    public interface ICreateAccountOperation
    {
        bool CreateAccount(Account account);
    }
}