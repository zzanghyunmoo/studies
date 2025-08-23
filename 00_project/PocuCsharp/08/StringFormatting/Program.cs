namespace StringFormatting;

class Program
{
    static void Main(string[] args)
    {
        string name = "Lulu";
        int id = 20250001;
        string message = string.Format("Name: {0}, ID: {1}", name, id);
        Console.WriteLine(message);
        Console.WriteLine("Name: {0}, ID: {1}", name, id);
        Console.WriteLine($"Name: {name}, ID: {id}");

        string student1 = "Kim Leon";
        float winRate1 = 30.2351f;
        string student2 = "Lulu";
        float winRate2 = 70.11f;

        Console.WriteLine("{0} {1}", "Name", "Win Rate");
        Console.WriteLine("{0} {1}", student1, winRate1);
        Console.WriteLine("{0} {1}", student2, winRate2);   

        Console.WriteLine("{0,10}{1,15}", "Name", "Win Rate");
        Console.WriteLine("{0,10}{1,15:f1}", student1, winRate1);
        Console.WriteLine("{0,10}{1,15:f1}", student2, winRate2);
    }
}
