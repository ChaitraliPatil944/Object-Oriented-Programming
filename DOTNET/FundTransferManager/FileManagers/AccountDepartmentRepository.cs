using System.Text.Json;
using FundTransfer.models;

namespace FundTransfer.FileManager
{
    public class AccountDepartmentRepository: IFileManager
    {
        public List<Account> GetAllAccounts()
        {
            string fileName = @"A:\TAP\GitHub\DotNet\FundTransferManager\Data\accounts.json";
            string jsonString = File.ReadAllText(fileName);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Account>? accounts = JsonSerializer.Deserialize<List<Account>>(jsonString, options);
            return accounts;
        }

        public List<Operation> GetAllOperations()
        {
            string fileName = @"A:\TAP\GitHub\DotNet\FundTransferManager\Data\operations.json";
            string jsonString = File.ReadAllText(fileName);
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            List<Operation>? operations = JsonSerializer.Deserialize<List<Operation>>(jsonString, options);
            return operations;
        }

        public bool SaveAllAccounts(List<Account> accounts)
        {
            bool status = false;
            string fileName = @"A:\TAP\GitHub\DotNet\FundTransferManager\Data\accounts.json";
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string jsonString = JsonSerializer.Serialize(accounts, options);
            File.WriteAllText(fileName, jsonString);
            status = true;
            return status; 
        }

        public bool SaveOpeations(List<Operation> accounts)
        {
            bool status = false;
            string fileName = @"A:\TAP\GitHub\DotNet\FundTransferManager\Data\operations.json";
            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
            string jsonString = JsonSerializer.Serialize(accounts, options);
            File.WriteAllText(fileName, jsonString);
            status = true;
            return status;
        }
    }
}