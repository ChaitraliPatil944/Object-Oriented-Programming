
using ActionListener.publishers;
using FundTransfer.FileManager;
using FundTransfer.Listener;
using FundTransfer.models;
using FundTransfer.NotificationServices;
using FundTransfer.UIManager;

int choice;

do
{
    UIManager ui = new UIManager();
    ui.DisplayMenu();

    choice = ui.GetChoice();
    IFileManager accountDepartmentRepository = new AccountDepartmentRepository();
    INotificationService smsService = new SMSService();
    List<Account> accounts = accountDepartmentRepository.GetAllAccounts();
    List<Operation> operations = accountDepartmentRepository.GetAllOperations();
    AccountDepartment accountDepartment = new AccountDepartment(accounts, smsService, accountDepartmentRepository);
    accountDepartment.addListener(new AccountEventHandler());
    switch (choice)
    {
        case 1:
        {
                string accno = ui.EnterAccountNumber();
            double balance = accountDepartment.GetBalance(accno);
            if (balance > 0)
            {
            ui.DisplayBalance(balance);
            }
            else
            {
                ui.DisplayMessage("Account not exists");
            }
            break;
    }
        case 2:
            {
                string accno = ui.EnterAccountNumber();
                double amount = ui.EnterAmount();
                bool status = accountDepartment.Withdraw(accno, amount);
                if (status)
                {
                    Operation newOperation = new Operation { AccountNumber = accno, Status = "D", StatusMessage = "ATM cash withdrawal.", OperationON = DateTime.Now ,Amount=amount };
                    operations.Add(newOperation);
                    accountDepartmentRepository.SaveOpeations(operations);
                    ui.DisplayMessage("withdraw amount succesfully");
                }
                else
                {
                    ui.DisplayMessage("does not withdraw amount first check your balance");
                }

                break;
            }
        case 3:
            {
                string accno = ui.EnterAccountNumber();
                double amount = ui.EnterAmount();
                bool status = accountDepartment.Deposite(accno, amount);
                if (status)
                {
                    Operation newOperation = new Operation { AccountNumber = accno, Status = "C", StatusMessage = "Salary credited to account", OperationON = DateTime.Now, Amount = amount };
                    operations.Add(newOperation);
                    accountDepartmentRepository.SaveOpeations(operations);
                    ui.DisplayMessage("deposite amount successfully");
                }
                else
                {
                    ui.DisplayMessage("does not Deposite amount first check your balance");
                }
                break;
            }
        case 4:
            {
                double amount = ui.EnterAmount();
                string fromAccount = ui.EnterAccountNumber("from: ");
                string toAccount = ui.EnterAccountNumber("To: ");

                bool status = accountDepartment.TranferFund(fromAccount, toAccount, amount);


                if (status)
                {
                    Operation newOperation1 = new Operation { AccountNumber = fromAccount, Status = "D", StatusMessage = "Fund transfer to "+toAccount, OperationON = DateTime.Now,Amount = amount };
                    Operation newOperation2 = new Operation { AccountNumber = toAccount, Status = "C", StatusMessage = "Fund received from "+fromAccount, OperationON = DateTime.Now, Amount = amount };
                    operations.Add(newOperation1);
                    operations.Add(newOperation2);
                    accountDepartmentRepository.SaveOpeations(operations);
                     ui.DisplayMessage("fund transfer successfully");
                }
                else
                {
                    ui.DisplayMessage("fund not transfer!! check your balance");
                }
                break;
            }

        case 5:
            {
                Account account=ui.GetAccountInfo();
                bool status=accountDepartment.CreateAccount(account);
                if (status)
                {
                    ui.DisplayMessage("account created successfully");
                }
                else
                {
                    ui.DisplayMessage("account not created");
                }
            }
            break;
            
        case 6:
            ui.ExitApplication();
            break;
    }
} while (choice != 5);
