namespace PrimitiveTypes;

class Program
{
    static void Main(string[] args)
    {
        int i1 = 2;
        int i2 = 10;

        float f1 = 10.23f;
        float f2 = 3.4f;

        double d1 = 11.0;
        double d2 = 5.234;

        char c1 = 'x';
        char c2 = '$';

        Console.WriteLine($"int: {i1} + {i2} = {i1 + i2}");
        Console.WriteLine($"int: {i1} - {i2} = {i1 - i2}");
        Console.WriteLine($"float: {f1} + {f2} = {f1 + f2}");
        Console.WriteLine($"double: {d1} + {d2} = {d1 + d2}");
        Console.WriteLine($"char: {c1} + {c2} = {(char)(c1 + c2)}");
    }
}
