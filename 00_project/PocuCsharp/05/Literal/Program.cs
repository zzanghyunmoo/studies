namespace Literal;

class Program
{
    static void Main(string[] args)
    {
        int i = 10;
        int b = 0b10;
        int h = 0x10;
        uint uI = 10u;
        float f = 10.0f;
        double d = 10.0;
        string s = "10";

        Console.WriteLine(i);
        Console.WriteLine(b);
        Console.WriteLine(h);
        Console.WriteLine(uI);
        Console.WriteLine(f);
        Console.WriteLine(d);
        Console.WriteLine(s);
    }
}
