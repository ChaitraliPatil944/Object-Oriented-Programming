
using System.Text;
using System.Text.Json;

using LMSApp.Entities;
namespace LMSApp.Managers;


public sealed  class FileIOManager
{
    private static FileIOManager _mgr; 
    private FileIOManager()
    {

    }

    public FileIOManager GetInstance()
    {
        if(_mgr == null)
        {
            _mgr=new FileIOManager();
        }
        return _mgr;
    }
    public  bool Serialize(string fileName, List<Person> people)
    {
        bool status =false;
        string jsonPeople= JsonSerializer.Serialize<List<Person>>(people );
        File.WriteAllText(fileName, jsonPeople);
        status=true;
        return status;
    }

    public  List<Person>   Deserialize(string fileName)
    {
        string jsonPeople=File.ReadAllText(fileName);
        List<Person> allMembers=JsonSerializer.Deserialize<List<Person>> (jsonPeople);
        return allMembers;
    }
}