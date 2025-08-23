namespace BitOperator;

class Program
{
    static void Main(string[] args)
    {
        byte b1 = 0b1100;
        byte b2 = 0b1001;

        // output format binary format 
        Console.WriteLine(Convert.ToString(b1 & b2, 2).PadLeft(8, '0'));  
        Console.WriteLine(Convert.ToString(b1 | b2, 2).PadLeft(8, '0'));  
        Console.WriteLine(Convert.ToString(b1 ^ b2, 2).PadLeft(8, '0'));  
        Console.WriteLine(Convert.ToString(~b2, 2).Substring(24, 8));  
        Console.WriteLine("Hello, World!");
    }
}
