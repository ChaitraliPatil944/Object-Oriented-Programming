public sealed class LMSConfigurationManager
{
    private static LMSConfigurationManager instance;

    public string InstituteName { get; private set; }
    public string Version { get; private set; }
    public string AdminContact { get; private set; }

    private LMSConfigurationManager()
    {
        InstituteName = "ABC Training Institute";
        Version = "1.0";
        AdminContact = "admin@abc.com";
    }

    public static LMSConfigurationManager GetInstance()
    {
        if (instance == null)
        {
            instance = new LMSConfigurationManager();
        }

        return instance;
    }
}