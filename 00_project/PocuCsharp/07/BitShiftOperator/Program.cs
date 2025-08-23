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
    }
}
