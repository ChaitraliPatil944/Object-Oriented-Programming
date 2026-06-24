namespace TFLBank.Handler;
using TFLBank.model;

public interface IAccountListener{
    void onUnderBalance(Account acct);

    void onOverBalance(Account acct);
}