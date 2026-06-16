using ConsoleApp;


// Define delegate type - matches the signature of arithmetic methods
public delegate double MathOperation(double a, double b);

class Program
    {
        static void Main(string[] args)
        {
            MathEngine mathEngine = new MathEngine();

            while (true)
            {
                Console.WriteLine("\n========Math Engine========");
                Console.WriteLine("Choose an operation:");
                Console.WriteLine("1. Addition");
                Console.WriteLine("2. Subtraction");
                Console.WriteLine("3. Multiplication");
                Console.WriteLine("4. Division");
                Console.WriteLine("5. Exit");
                Console.Write("Enter your choice: ");
                
                string choice = Console.ReadLine();

                if (choice == "5")
                {
                    Console.WriteLine("Exiting...");
                    break;
                }

                Console.WriteLine("Enter first number:");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter second number:");
                double b = Convert.ToDouble(Console.ReadLine());

                // Declare delegate variable
                MathOperation operation = null;

                // Bind the appropriate method to the delegate at runtime
                switch (choice)
                {
                    case "1":
                        operation = mathEngine.Add;
                        break;
                    case "2":
                        operation = mathEngine.Subtract;
                        break;
                    case "3":
                        operation = mathEngine.Multiply;
                        break;
                    case "4":
                        operation = mathEngine.Divide;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        continue;
                }

                // Execute the operation through the delegate
                if (operation != null)
                {
                    double result = operation(a, b);
                    Console.WriteLine($"Result: {result}");
                }
            }
        }
    }
