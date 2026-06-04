class RefandOut{
    public static void Main(String[] args){
        int x =9;
   int y = 7;
   int area, perimeter;
   int length = 5;
   int breadth = 3;
   Console.WriteLine($"Before swapping: x = {x}, y = {y}");
        
        RefandOut obj = new RefandOut(); // allowed to create an object of the class because it is a static method, but the method itself is not static
        obj.swap(ref x, ref y);
        Console.WriteLine($"After swapping: x = {x}, y = {y}");
        obj.calculate(length, breadth, out area, out perimeter);
        Console.WriteLine($"Area: {area}");
        Console.WriteLine($"Perimeter: {perimeter}");
    }
    public void swap (ref int a ,ref int b){
        int temp = a;
        a = b;
        b = temp;
    }

    public void calculate(int length, int breadth, out int area, out int perimeter){
        area = length * breadth;
        perimeter = 2 * (length + breadth);
    }
}