namespace BitShiftOperator;

class Program
{
    static void Main(string[] args)
    {
        int b = 0b0010;     // 2
        int left = b << 1;  // 4
        int right = b >> 1; // 1

        Console.WriteLine($"b: {Convert.ToString(b, 2).PadLeft(4, '0')}");
        Console.WriteLine($"left: {Convert.ToString(left, 2).PadLeft(4, '0')}");
        Console.WriteLine($"right: {Convert.ToString(right, 2).PadLeft(4, '0')}");

        int num = 1;
        int res1 = num << 1;
        Console.WriteLine(res1); // 2

        int res2 = num << 2;
        Console.WriteLine(res2); // 4

        int res3 = num << 3;
        Console.WriteLine(res3); // 8

        int res4 = res3 >> 1;
        Console.WriteLine(res4); // 4

        int res5 = res3 >> 2;
        Console.WriteLine(res5); // 2

        int res6 = res3 >> 3;
        Console.WriteLine(res6); // 1
    }
}
