
namespace LMSApp.Managers;
using LMSApp.Entities;

public class LMSConfigurationManager
{
   private static LMSConfigurationManager instance;
   public string InstituteName { get; set; }
   public string Version { get; set; }
   public string AdminContact { get; set; }

    private LMSConfigurationManager(string instituteName, string version, string adminContact)
    {
         InstituteName = instituteName;
         Version = version;
         AdminContact = adminContact;
    }

    public static LMSConfigurationManager GetInstance(string instituteName, string version, string adminContact)
    {
        if (instance == null)
        {
            instance = new LMSConfigurationManager(instituteName, version, adminContact);
        }
        return instance;
    }
}