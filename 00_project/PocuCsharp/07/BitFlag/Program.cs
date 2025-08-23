namespace BitFlag;

class Program
{
    static void Main(string[] args)
    {
        const int BIT_FLAG_SIZE = 8;
        byte bitFlags = 0b0000_0000;
        byte mask1 = 0b0000_0001 << 2; // 0000_0100

        bitFlags |= mask1;
        Console.WriteLine(Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

        byte mask2 = (0b0000_0001 << 3) | (0b0000_0001 << 5); // 0010_1000
        bitFlags |= mask2; // 0010_1100
        Console.WriteLine(Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

        bitFlags &= (byte)~mask1;
        Console.WriteLine(Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));

        bitFlags &= 0;
        Console.WriteLine(Convert.ToString(bitFlags, 2).PadLeft(BIT_FLAG_SIZE, '0'));
    }
}
