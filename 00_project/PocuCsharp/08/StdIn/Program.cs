namespace StdIn;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine() ?? "Unknown";
        Console.WriteLine($"Hello, {name}!");

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine() ?? "Unknown";
        if (!int.TryParse(ageInput, out int age))
        {
            Console.WriteLine("Invalid age. Please enter a number.");
            return;
        }

        Console.WriteLine($"You are {age} years old.");
    }
}
