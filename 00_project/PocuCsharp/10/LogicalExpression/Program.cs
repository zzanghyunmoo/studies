namespace LogicalExpression;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter your score: ");
        string input = Console.ReadLine() ?? "invalid";
        if (input == "invalid")
        {
            Console.WriteLine("error: Invalid input. Please enter a valid number.");
            return;
        }

        if (int.TryParse(input, out int score))
        {
            // Console.WriteLine($"Your math score is {score}.");
        }
        else
        {
            Console.WriteLine("error: Invalid input. Please enter a valid number.");
            return;
        }

        if (score >= 90)
        {
            Console.WriteLine("You got an Gaming box.");
        }
        else if (score >= 80)
        {
            Console.WriteLine("You got a Book.");
        }
        else if (score >= 70)
        {
            Console.WriteLine("You got a Pizza.");
        }
        else
        {
            Console.WriteLine("You failed the math exam.");
        }
    }
}
