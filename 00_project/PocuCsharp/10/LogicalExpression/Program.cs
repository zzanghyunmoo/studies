namespace LogicalExpression;

class Program
{
    static void Main(string[] args)
    {
        int num1 = 1;
        int num2 = 1;
        int num3 = 4;

        bool b1 = !(num1 == num2) && (num3 > num2);
        bool b2 = (num1 < num2) || (num2 == num3);
        bool b3 = (num1 > num2) || num1 == num3 || ++num1 > num2;
        bool b4 = (num3 >= num2) || num1-- == num2;
        bool b5 = num3 == num1 && --num2 > num1;
        Console.WriteLine($"b1: {b1}, b2: {b2}, b3: {b3}, b4: {b4}, b5: {b5}");
    }
}
