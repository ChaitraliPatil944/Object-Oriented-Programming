public class CommandLineArguments{
    public static void Main(string[] args){
        
        Console.WriteLine("Command Line Argumemts length ,{0}",args.Length);
        foreach(string i in args){
            Console.WriteLine(i);
        }

          
    }
}