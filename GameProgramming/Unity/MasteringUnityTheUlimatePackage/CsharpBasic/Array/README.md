# 배열(Array)과 리스트(List)

프로그래밍에서 여러 개의 데이터를 효율적으로 관리하기 위해 사용하는 가장 기본적인 자료구조인 배열과 리스트에 대해 알아봅니다.

## 📚 학습 목표

- 배열(Array)의 개념과 특징을 이해합니다.
- 리스트(List) 또는 동적 배열(Dynamic Array)의 개념과 특징을 이해합니다.
- 배열과 리스트의 차이점을 알고 상황에 맞게 사용하는 능력을 기릅니다.

---

## 1. 배열 (Array)

배열은 **같은 타입의 데이터 여러 개를 연속된 메모리 공간에 순서대로 저장**하는 자료구조입니다.

### ✨ 특징

- **고정된 크기**: 배열은 처음 생성할 때 크기가 정해지며, 이후에는 변경할 수 없습니다.
- **인덱스 (Index)**: 배열의 각 데이터는 `0`부터 시작하는 고유한 번호(인덱스)를 가집니다. 이 인덱스를 통해 데이터에 매우 빠르게 접근할 수 있습니다. (시간 복잡도: O(1))
- **연속된 메모리**: 데이터들이 메모리 상에 차례대로 나란히 저장됩니다.

### 👍 장점

- 인덱스를 이용한 데이터 접근 속도가 매우 빠릅니다.

### 👎 단점

- 크기가 고정되어 있어 유연하지 않습니다.
- 중간에 데이터를 추가하거나 삭제하는 작업이 비효율적입니다. (뒤따르는 모든 데이터를 이동시켜야 함)

### 📝 간단한 코드 예시 (C#)

```csharp
// GiftBox 클래스 정의
class GiftBox
{
    public string Letter;
    public int Money;
}

// 배열 생성 및 초기화
GiftBox[] giftBoxes = new GiftBox[3];
giftBoxes[0] = new GiftBox() { Letter = "Happy Birthday!", Money = 10000 };
giftBoxes[1] = new GiftBox() { Letter = "Merry Christmas!", Money = 5000 };
giftBoxes[2] = new GiftBox() { Letter = "Happy New Year!", Money = 1000 };

// for문을 사용한 배열의 모든 요소 순회
for (int i = 0; i < giftBoxes.Length; i++)
{
    Console.WriteLine(giftBoxes[i].Letter + " " + giftBoxes[i].Money);
}
```


## 2. 리스트 (List) / 동적 배열 (Dynamic Array)

리스트는 배열과 유사하지만, **크기가 정해져 있지 않고 동적으로 변할 수 있는** 자료구조입니다. 많은 프로그래밍 언어에서 `ArrayList`, `Vector`, `List` (Python), `Slice` (Go) 등의 이름으로 구현되어 있습니다.

### ✨ 특징

- **동적인 크기**: 필요에 따라 데이터의 개수를 자유롭게 늘리거나 줄일 수 있습니다.
- **자동 크기 조절**: 리스트가 꽉 차면, 내부적으로 더 큰 배열을 새로 만든 뒤 기존 데이터를 복사하는 방식으로 크기를 조절합니다.

### 👍 장점

- 데이터의 개수를 예측할 수 없을 때 유용하며, 크기 걱정 없이 데이터를 추가/삭제할 수 있어 편리합니다.

### 👎 단점

- 데이터 접근 속도는 배열처럼 빠르지만(O(1)), 내부적으로 크기를 재조정하는 작업이 발생할 때 순간적인 성능 저하가 있을 수 있습니다.
- 배열에 비해 약간의 추가적인 메모리(크기, 용량 정보 등)를 사용합니다.

### 📝 간단한 코드 예시 (C#)

```csharp
// GiftBox 클래스 정의
class GiftBox
{
    public string Letter;
    public int Money;
}

// 동적 리스트 생성
List<GiftBox> giftBoxes = new List<GiftBox>();
giftBoxes.Add(new GiftBox() { Letter = "Happy Birthday!", Money = 10000 });
giftBoxes.Add(new GiftBox() { Letter = "Merry Christmas!", Money = 5000 });
giftBoxes.Add(new GiftBox() { Letter = "Happy New Year!", Money = 1000 });

// List의 요소 개수는 Count 속성으로 알 수 있습니다
Console.WriteLine(giftBoxes.Count); // 출력: 3

// foreach문을 사용한 리스트의 모든 요소 순회
foreach (var box in giftBoxes)
{
    Console.WriteLine(box.Letter + " " + box.Money);
}

// 리스트의 모든 요소 삭제
giftBoxes.Clear();
Console.WriteLine(giftBoxes.Count); // 출력: 0
```