using FundTransfer.Listener;
using FundTransfer.NotificationServices;
using FundTransfer.TransactionManager.operations;
using FundTransfer.models;
using FundTransfer.FileManager;

namespace ActionListener.publishers
{
    public class AccountDepartment : IDepositeOperation, IWithdrawOperation, IFundTransferOperation, ICreateAccountOperation
    {

        public List<Account> accounts { get; set; }
        private List<IAccountListener> listeners = new List<IAccountListener>();
        private INotificationService notificationService;
        private IFileManager fileManager;

        public AccountDepartment(List<Account> account, INotificationService notificationService,IFileManager fileManager)
        {
            this.accounts = account;
            this.notificationService = notificationService;
            this.fileManager = fileManager;
        }


        public double GetBalance(string accountId)
        {
            foreach (Account account in accounts)
            {
                if (account.AccountNumber == accountId)
                {
                    return account.Balance;
                }
            }
            return 0;
        }


        public bool Deposite(string accountId, double amount)
        {
            bool status = false;
            foreach (Account account in accounts)
            {
                if (account.AccountNumber == accountId)
                {
                    account.Balance += amount;
                    CheckBalance(account);
                    if (amount > 50000)
                    {
                        status = false;
                    }
                    else
                    {
                        status = true;
                        fileManager.SaveAllAccounts(accounts);
                    }
                    break;
                }
            }
            return status;
        }
        public bool Withdraw(string accountId, double amount)
        {
            bool status=false;
            foreach (Account account in accounts)
            {
                if (account.AccountNumber == accountId)
                {
                    account.Balance -= amount;
                    CheckBalance(account);
                    if (account.Balance < 0)
                    {
                        status=false;
                    }
                    else
                    {
                        status=true;
                        fileManager.SaveAllAccounts(accounts);
                    }
                    break;
                }
            }

            return status;
        }
        
        public bool TranferFund(string fromAccountId, string toAccountId, double amount)
        {
            bool status = false;
            Account fromAccount=new Account();
            Account toAccount=new Account();
            foreach(Account account in accounts)
            {
                if (account.AccountNumber == fromAccountId)
                {
                    fromAccount=account;
                    break;
                }
            }

            foreach (Account account in accounts)
            {
                if (account.AccountNumber == toAccountId)
                {
                    toAccount = account;
                    break;
                }
            }
            
            bool depositeStatus;
            bool withdrawStatus=Withdraw(fromAccount.AccountNumber,amount);

           if (withdrawStatus)
            {
                depositeStatus=Deposite(toAccount.AccountNumber, amount);
                if(!depositeStatus)
                {
                    Deposite(fromAccount.AccountNumber, amount);
                }
                if (withdrawStatus && depositeStatus)
                {
                    status = true;
                }
            }
           
            return status;
        }
    
         public bool CreateAccount(Account account)
        {
            bool status=false;
            accounts.Add(account);
            fileManager.SaveAllAccounts(accounts);
            status =true;
            return status;
        }
        private void CheckBalance(Account account)
        {

            if (account.Balance < 1000)
            {
                foreach (IAccountListener l in listeners)
                {
                    l.OnUnderBalance(account.Balance);
                    notificationService.send("Amount is less than  minimum balance policy");
                }
            }

            if (account.Balance > 25000)
            {
                foreach (IAccountListener l in listeners)
                {
                    l.OnOverBalance(account.Balance);
                    notificationService.send("Amount is greater than  Taxable income policy");
                }
            }



        }

        public void addListener(IAccountListener listener)
        {
            listeners.Add(listener);
        }
    }
}