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
        Gift[] gifts =
        [
            new("Teddy Bear", 20),
            new("Lego Set", 35),
            new("Puzzle", 15),
            new("Action Figure", 25)
        ];

        // 수동으로 출력
        Console.WriteLine($"Gift: {gifts[0].Name}, Price: ${gifts[0].Price}");
        Console.WriteLine($"Gift: {gifts[1].Name}, Price: ${gifts[1].Price}");
        Console.WriteLine($"Gift: {gifts[2].Name}, Price: ${gifts[2].Price}");
        Console.WriteLine($"Gift: {gifts[3].Name}, Price: ${gifts[3].Price}");
        Console.WriteLine("==========================");
        
        // 만약 100개였다면 어땠을까?        
        // for문의 장점: 반복 작업을 자동화 
        // for 루프를 사용하여 출력
        for (int i = 0; i < gifts.Length; i++)
        {
            Gift gift = gifts[i];
            Console.WriteLine($"Gift: {gift.Name}, Price: ${gifts[i].Price}");
        }
        Console.WriteLine("==========================");

        // foreach 루프를 사용하여 출력
        // foreach문의 장점: 배열이나 컬렉션의 모든 항목에 대해 자동으로 반복
        foreach (var gift in gifts)
        {
            Console.WriteLine($"Gift: {gift.Name}, Price: ${gift.Price}");
        }
        Console.WriteLine("==========================");
    }
}
