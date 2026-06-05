public class ArrayOperations {
    public static void Main(string[] args) {
        int[] numbers = { 1, 2, 3, 4, 5 };
        Console.WriteLine("Original array:");
        PrintArray(numbers);

        // Reverse the array
        Array.Reverse(numbers);
        Console.WriteLine("Reversed array:");
        PrintArray(numbers);

        // Sort the array
        Array.Sort(numbers);
        Console.WriteLine("Sorted array:");
        PrintArray(numbers);

        // Find the index of a specific element
        int index = Array.IndexOf(numbers, 3);
        Console.WriteLine($"Index of element '3': {index}");
    }

    public static void PrintArray(int[] arr) {
        foreach (int num in arr) {
            Console.Write(num + " ");
        }
        Console.WriteLine();
    }
}