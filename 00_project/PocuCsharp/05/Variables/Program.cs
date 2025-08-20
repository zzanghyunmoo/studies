namespace Variables;

class Program
{
    static void Main(string[] args)
    {
        const float NUM_1 = 10.0f;
        const float NUM_2 = 20.0f;

        Console.WriteLine("{0} + {1} = {2}", NUM_1, NUM_2, NUM_1 + NUM_2);
        Console.WriteLine("{0} - {1} = {2}", NUM_1, NUM_2, NUM_1 - NUM_2);
        Console.WriteLine("{0} * {1} = {2}", NUM_1, NUM_2, NUM_1 * NUM_2);
        Console.WriteLine("{0} / {1} = {2}", NUM_1, NUM_2, NUM_1 / NUM_2);
    }
}
