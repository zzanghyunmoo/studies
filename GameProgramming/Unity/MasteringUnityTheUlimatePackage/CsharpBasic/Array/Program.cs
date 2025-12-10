namespace Array;

class GiftBox
{
    public string Letter;
    public int Money;
};

class Program
{
    static void Main(string[] args)
    {
        GiftBox a = new GiftBox()
        {
            Letter = "Happy Birthday!",
            Money = 10000
        };
        GiftBox b = new GiftBox()
        {
            Letter = "Merry Christmas!",
            Money = 5000
        };
        GiftBox c = new GiftBox()
        {
            Letter = "Happy New Year!",
            Money = 1000
        };
        // Array는 공간이 제약된 동일한 타입의 변수들을 연속적으로 배치한 자료구조이다.
        GiftBox[] giftBoxes = new GiftBox[3];
        giftBoxes[0] = a;
        giftBoxes[1] = b;
        giftBoxes[2] = c;

        for (int i = 0; i < giftBoxes.Length; i++)
        {
            Console.WriteLine(giftBoxes[i].Letter + " " + giftBoxes[i].Money);
        }

        GiftBox d = new() { Letter = "Happy Valentine's Day!", Money = 2000 };
        GiftBox e = new() { Letter = "Happy Halloween!", Money = 3000 };
        GiftBox[] giftBoxes2= new GiftBox[]
        {
            d,
            e
        };
        // 배열의 길이는 Length 속성으로 알 수 있다.
        Console.WriteLine(giftBoxes2.Length);

        // foreach문은 배열이나 컬렉션의 모든 요소를 순회할 때 사용하는 반복문이다.
        foreach (var box in giftBoxes2)
        {
            Console.WriteLine(box.Letter + " " + box.Money);
        }

        List<GiftBox> giftBoxes3 = new List<GiftBox>();
        giftBoxes3.Add(a);
        giftBoxes3.Add(b);
        giftBoxes3.Add(c);
        giftBoxes3.Add(d);

        // List는 크기가 동적으로 변하는 배열과 유사한 자료구조이다.
        // List의 요소 개수는 Count 속성으로 알 수 있다.
        Console.WriteLine(giftBoxes3.Count);
        // List도 foreach문으로 모든 요소를 순회할 수 있다.
        foreach (var box in giftBoxes3)
        {
            Console.WriteLine(box.Letter + " " + box.Money);
        }

        giftBoxes3.Clear();
        Console.WriteLine(giftBoxes3.Count);
    }
}
