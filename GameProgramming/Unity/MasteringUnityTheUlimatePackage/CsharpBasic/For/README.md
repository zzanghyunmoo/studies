# C#의 반복문: for와 for-each

프로그래밍을 하다 보면 똑같은 작업을 여러 번 반복해야 할 때가 많습니다.

예를 들어, `Program.cs` 파일에 있는 선물 목록을 하나씩 화면에 출력하는 작업을 생각해 보세요. 선물이 4개뿐이라면 아래처럼 하나씩 수동으로 코드를 작성할 수 있습니다.

```csharp
// 수동으로 출력
Console.WriteLine($"Gift: {gifts[0].Name}, Price: ${gifts[0].Price}");
Console.WriteLine($"Gift: {gifts[0].Name}, Price: ${gifts[1].Price}");
Console.WriteLine($"Gift: {gifts[0].Name}, Price: ${gifts[2].Price}");
Console.WriteLine($"Gift: {gifts[0].Name}, Price: ${gifts[3].Price}");
```

하지만 만약 선물이 100개, 1000개라면 어떨까요? 이렇게 수동으로 작업하는 것은 거의 불가능에 가깝습니다. 바로 이럴 때 **반복문**이 아주 유용하게 사용됩니다.

여기서는 가장 대표적인 반복문인 `for`와 `foreach`에 대해 알아보겠습니다.

## 1. for 루프: 정해진 횟수만큼 반복하기

`for` 루프는 **반복 작업을 자동화**하는 데 아주 효과적입니다. "이 작업을 N번 반복해줘"라고 컴퓨터에게 명령할 수 있죠.

`for` 루프는 `(초기화식; 조건식; 증감식)` 세 부분으로 구성됩니다.

1.  **초기화식**: 루프가 시작될 때 딱 한 번 실행됩니다. (예: `int i = 0`)
2.  **조건식**: 매번 반복하기 전에 이 조건을 확인하고, 참(true)일 때만 코드를 실행합니다. (예: `i < gifts.Length`)
3.  **증감식**: 루프 안의 코드를 한 번 실행한 후에 실행됩니다. (예: `i++`)

### 예제 코드 (`Program.cs` 참고)

`Program.cs`의 선물 목록을 `for` 루프를 사용해 출력하는 코드입니다.

```csharp
// for 루프를 사용하여 출력
for (int i = 0; i < gifts.Length; i++)
{
    Gift gift = gifts[i];
    Console.WriteLine($"Gift: {gift.Name}, Price: ${gift.Price}");
}
```

**코드 설명:**

*   `int i = 0;`: `i`라는 카운터 변수를 0으로 시작합니다. (배열의 첫 번째 항목은 0번부터 시작하니까요!)
*   `i < gifts.Length;`: `i`가 선물 배열의 전체 개수(`gifts.Length`)보다 작은 동안 계속 반복합니다.
*   `i++`: 루프가 한 번 끝날 때마다 `i`의 값을 1씩 증가시킵니다.
*   `Gift gift = gifts[i];`: `i`번째 선물을 가져와 `gift` 변수에 담습니다.

이 코드는 선물 배열에 있는 모든 선물을 처음부터 끝까지 순서대로 출력해 줍니다.

## 2. foreach 루프: 컬렉션의 모든 항목에 대해 반복하기

`foreach` 루프는 `for` 루프보다 좀 더 직관적이고 간결한 방법입니다. 배열이나 리스트 같은 데이터 묶음(컬렉션)에 들어있는 **모든 항목을 하나씩 처음부터 끝까지** 살펴볼 때 사용합니다.

"이 컬렉션에 있는 모든 항목에 대해서 이 작업을 해줘" 라는 의미로 이해하면 쉽습니다.

### 예제 코드 (`Program.cs` 참고)

`foreach`를 사용하면 코드가 얼마나 더 간단해지는지 확인해 보세요.

```csharp
// foreach 루프를 사용하여 출력
foreach (var gift in gifts)
{
    Console.WriteLine($"Gift: {gift.Name}, Price: ${gift.Price}");
}
```

**코드 설명:**

*   `foreach (var gift in gifts)`: `gifts` 배열에서 선물을 하나씩 순서대로 꺼내 `gift`라는 변수에 담아 `{}` 안의 코드를 실행합니다.
*   `for` 루프처럼 카운터 변수(`i`)나 배열의 길이를 신경 쓸 필요 없이, 배열에 있는 모든 항목을 알아서 처리해주기 때문에 코드가 훨씬 깔끔하고 읽기 쉬워집니다.

## 정리

*   **`for` 루프**: 반복 횟수가 정해져 있거나, 현재 몇 번째 반복인지(인덱스) 알아야 할 때 유용합니다.
*   **`foreach` 루프**: 배열이나 리스트의 모든 항목에 대해 작업을 수행할 때 코드를 간결하게 작성할 수 있어 편리합니다.

이제 반복적인 작업이 필요할 때 두려워하지 말고 `for`와 `foreach`를 자신 있게 사용해 보세요!

