namespace TFLBank.Repository;
using TFLBank.model;

public interface IAccountRepository {
    List<Account> GetAllAccounts();

    bool SaveAllAccounts(List<Account> accounts);

}