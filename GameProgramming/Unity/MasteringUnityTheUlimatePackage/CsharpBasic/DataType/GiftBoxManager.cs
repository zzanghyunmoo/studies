namespace DataType;

class GiftBoxManager
{
    public void Init()
    {
        // 기본 생성자를 사용하여 GiftBox 객체 생성
        GiftBox[] boxes =
        [
            CreateGiftBox("Happy Birthday!", 100, 10000000000L, 2.5f, 10.75, false, BoxGrade.NORMAL),
            CreateGiftBox("Congratulations!", 200, 5000000000L, 3.0f, 12.5, true, BoxGrade.RARE),
            CreateGiftBox("Merry Christmas!", 150, 8000000000L, 2.8f, 11.0, false, BoxGrade.EPIC)
        ];

        foreach (var box in boxes)
        {
            Console.WriteLine($"Letter: {box.Letter}, Grade: {box.Grade}");
        }
    }

    public GiftBox CreateGiftBox(string letter, int money, long distance, float weight, double height, bool isOpen, BoxGrade grade)
    {
        GiftBox giftBox = new GiftBox()
        {
            Letter = letter,
            FirstLetter = letter[0],
            Money = money,
            Distance = distance,
            Weight = weight,
            Height = height,
            IsOpen = isOpen,
            Grade = grade
        };
        return giftBox;
    }
}

