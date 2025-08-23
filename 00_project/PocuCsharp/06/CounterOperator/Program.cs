namespace CounterOperator;

class Program
{
    static void Main(string[] args)
    {
        int i = 10;
        int res1 = i++;
        Console.WriteLine($"i: {i}, res: {res1}"); // i: 11, res: 10
        int res2 = ++i;
        Console.WriteLine($"i: {i}, res: {res2}"); // i: 12, res: 12

        int res3 = i--;
        Console.WriteLine($"i: {i}, res: {res3}"); // i: 11, res: 12
        int res4 = --i;
        Console.WriteLine($"i: {i}, res: {res4}"); // i: 10, res: 10
    }
}
