namespace Notification
{

    //delegate: is a typesafe , object oriented Function Pointer
    //delegate is a wrapper to function pointer

    public class Program{


    //Step 1
    public delegate void OrderOperation(int orderId);

    //Step 2

    public static void ProcessOrder(int orderId)
    {
        Console.WriteLine("Order is processed");
    }

    public static void CancelOrder(int orderId)
    {
        Console.WriteLine("Order is canceled");
    }

     public static void ShipProduct(int orderId)
    {
        Console.WriteLine("rRoduct is deliverd to customer end");
    }

    public static void Main(string [] args){

        //Step 4: Create all instances of delegate with function name
        //Direct function call
        //ProcessOrder(); //compile  linking


        OrderOperation o1=new OrderOperation(ProcessOrder); 
        OrderOperation o2=new OrderOperation(CancelOrder);  //runtime linking
        OrderOperation o3=new OrderOperation(ShipProduct); 
        

        //Step 5: invoke Delegate

        //Unicast delegate
        o3.Invoke(98);  //indirect function call



        OrderOperation masterO=null;

        //chaining delegate 

        //attach delegates
        //Multicast Delegate

        masterO+=o1;
        masterO+=o2;
        masterO+=o3;
        
        masterO(876);
        Console.WriteLine("After detachment");

        masterO-=o3;
        masterO(876);

    }
    }
}