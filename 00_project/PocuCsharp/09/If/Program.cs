namespace If;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first number: ");
        string firstInput = Console.ReadLine() ?? "unknown";
        if (int.TryParse(firstInput, out int firstNumber))
        {
            // Console.WriteLine($"You entered: {firstNumber}");
        }
        else
        {
            Console.WriteLine("error: invalid number");
        }

        Console.Write("Enter the second number: ");
        string secondInput = Console.ReadLine() ?? "unknown";
        if (int.TryParse(secondInput, out int secondNumber))
        {
            // Console.WriteLine($"You entered: {secondNumber}");
        }
        else
        {
            Console.WriteLine("error: invalid number");
        }

        Console.Write("Enter operator (+ - * /): ");
        string operatorInput = Console.ReadLine() ?? "unknown";

        if (operatorInput == "+")
        {
            Console.WriteLine($"{firstNumber} + {secondNumber} = {firstNumber + secondNumber}");
        }
        else if (operatorInput == "-")
        {
            Console.WriteLine($"{firstNumber} - {secondNumber} = {firstNumber - secondNumber}");
        }
        else if (operatorInput == "*")
        {
            Console.WriteLine($"{firstNumber} * {secondNumber} = {firstNumber * secondNumber}");
        }
        else if (operatorInput == "/")
        {
            if (secondNumber == 0)
            {
                Console.WriteLine("error: Cannot divide by zero");
            }

            Console.WriteLine($"{firstNumber} / {secondNumber} = {(double)firstNumber / secondNumber:f2}");
        }
        else
        {
            Console.WriteLine("error: invalid operator");
        }
    }
}
