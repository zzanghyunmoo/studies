namespace For;

class Gift
{
    public string Name { get; set; }
    public int Price { get; set; }

    public Gift(string name, int price)
    {
        Name = name;
        Price = price;
    }
}

class Program
{
    static void Main(string[] args)
    {
        var gifts = new Gift[]
        {
            new Gift("Teddy Bear", 20),
            new Gift("Lego Set", 35),
            new Gift("Puzzle", 15),
            new Gift("Action Figure", 25)
        };

        
        Console.WriteLine("Hello, World!");
    }
}
