namespace ExplicitTypeConversion;

class Program
{
    static void Main(string[] args)
    {
        double d1 = 10.9;
        double d2 = 52.16;
        Console.WriteLine($"{d1 + d2}");
        Console.WriteLine($"{(int)(d1 + d2)}");
        Console.WriteLine($"{(int)d1 + (int)d2}");
    }
}
