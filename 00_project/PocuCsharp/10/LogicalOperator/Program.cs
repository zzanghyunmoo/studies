namespace LogicalOperator;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 10;
        int num2 = 20;
        if (num1 == 10 || ++num2 == 21)
        {
            num1++;
        }

        Console.WriteLine($"num1: {num1}, num2: {num2}"); // Output: num1: 11, num2: 20
        if (num1 == 11 && ++num2 == 21)
        {
            num1++;
        }

        Console.WriteLine($"num1: {num1}, num2: {num2}"); // Output: num1: 12, num2: 21
    }
}
