namespace MathOperator;

class Program
{
    static void Main(string[] args)
    {
        int a = 100;
        int b = 21;

        // Addition
        int add = a + b;
        Console.WriteLine($"Add: {add}");

        // Subtraction
        int sub = a - b;
        Console.WriteLine($"Substraction: {sub}");

        // Multiplication
        int mul = a * b;
        Console.WriteLine($"Multiplication: {mul}");

        // Division
        double div = (double)a / b;
        Console.WriteLine($"Division: {div}");

        // Modulus
        int mod = a % b;
        Console.WriteLine($"Modulus: {mod}");
    }
}
