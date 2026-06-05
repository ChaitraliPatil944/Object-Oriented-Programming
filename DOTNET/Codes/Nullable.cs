public class DatabaseReader{

    public float? floatValue=8.23f;
    public bool? boolValue= true;
    public string? stringValue= "Chait";  

    public void GetValues(){
        Console.WriteLine("Checking if float has value :"+floatValue.HasValue);
        if (floatValue.HasValue){
            Console.WriteLine("Float value is:"+floatValue.Value);

        }else{
            Console.WriteLine("Float value is null");
        }
        Console.WriteLine("Checking if bool has value :"+boolValue.HasValue);
        if (boolValue.HasValue){
            Console.WriteLine("Bool value is:"+boolValue.Value);        
        }else{
            Console.WriteLine("Bool value is null");
        }
        Console.WriteLine("Checking if string has value : {0}", stringValue!=null);
        if (stringValue!=null){
            Console.WriteLine("String value is:"+stringValue);
        }else{
            Console.WriteLine("String value is null");
            }        

        
    }
}
public class MainClass{
    public static void Main(string[] args){
        DatabaseReader reader = new DatabaseReader();
        reader.GetValues();
    }
}