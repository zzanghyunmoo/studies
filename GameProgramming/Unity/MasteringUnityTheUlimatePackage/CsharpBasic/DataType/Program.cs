namespace DataType;

class Program
{
    static void Main(string[] args)
    {
        GiftBoxManager giftBoxManager = new();
        giftBoxManager.Init();

        GiftBox giftBox = giftBoxManager.CreateGiftBox(
            "Happy Birthday!",
            100,
            10000000000L,
            2.5f,
            10.75,
            false,
            BoxGrade.RARE
        );

        // 문자열은 문자들의 집합이므로 인덱스를 사용하여 각 문자에 접근할 수 있습니다.
        for (int i = 1; i < giftBox.Letter.Length; i++)
        {
            Console.WriteLine($"{i}th letter: {giftBox.Letter[i]}");  
        }

        Console.WriteLine($"Box Grade: {giftBox.Grade}");


        // 형 변환
        // int -> string
        string numStr = giftBox.Money.ToString();
        Console.WriteLine(numStr);
        
        numStr = 200 + "";
        Console.WriteLine(numStr);

        // string -> int (기본 타입)
        int num = int.Parse(numStr);
        Console.WriteLine(num);

        numStr = 300 + "";
        int.TryParse(numStr, out num);
        Console.WriteLine(num);


        // float -> double, int -> long, short -> int, short -> long(Implicit 큰 타입에 작은 타입 할당)
        double d = giftBox.Weight;
        double d2 = 30.0 + 10.2f;

        // double -> float, long -> int (반대로는 강제 형변환 필요)
        float f = (float) giftBox.Height;
        float f2 = 10.2f + (float) 30.0;
    }
}
