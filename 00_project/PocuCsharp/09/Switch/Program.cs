namespace Switch;

class Program
{
    static int Main(string[] args)
    {
        Console.WriteLine("Please select a menu");
        Console.WriteLine("1. Cheese burger");
        Console.WriteLine("2. Double Chicken burger");
        Console.WriteLine("3. Veggie burger");
        Console.WriteLine("4. Cheese & mushroom burger");
        Console.Write("Menu (1-4): ");
        
        string? input = Console.ReadLine();
        if (input == null)
        {
            Console.WriteLine("Console.ReadLine() returned null");
            return -1;
        }

        bool isParse = int.TryParse(input, out int menu);
        if (!isParse)
        {
            Console.WriteLine("Input is not a number");
            return -1;
        }

        switch (menu)
        {
            case 1:
                Console.WriteLine("You have selected Cheese burger");
                break;
            case 2:
                Console.WriteLine("You have selected Double Chicken burger");
                break;
            case 3:
                Console.WriteLine("You have selected Veggie burger");
                break;
            case 4:
                Console.WriteLine("You have selected Cheese & mushroom burger");
                break;
            default:
                Console.WriteLine("Unknown menu");
                break;
        }

        return 0;
    }
}
