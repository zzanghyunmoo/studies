# C#의 기본 데이터 타입 (Data Types)

C# 프로그래밍에서 데이터를 저장하고 다루기 위해 사용하는 기본적인 데이터 타입에 대해 알아봅니다. 데이터 타입은 변수가 어떤 종류의 값을 저장할 수 있는지를 결정합니다.

## 📚 학습 목표

- C#의 기본 데이터 타입들을 이해하고 구분합니다.
- 각 데이터 타입의 특징과 용도를 파악합니다.
- 데이터 타입 간의 형 변환 방법을 배웁니다.
- 열거형(Enum)의 개념과 사용법을 익힙니다.

---

## 1. 기본 데이터 타입 개요

C#에서는 다양한 종류의 데이터를 다루기 위해 여러 가지 기본 데이터 타입을 제공합니다. 이들은 크게 **값 타입(Value Types)**과 **참조 타입(Reference Types)**으로 나뉩니다.

### 값 타입 (Value Types)
값 타입은 데이터를 직접 저장하며, 스택 메모리에 저장됩니다. 여기에는 정수, 실수, 논리, 문자 등이 포함됩니다.

### 참조 타입 (Reference Types)
참조 타입은 데이터의 메모리 주소를 저장하며, 힙 메모리에 실제 데이터를 저장합니다. 대표적으로 `string`이 있습니다.

---

## 2. 주요 데이터 타입 설명

### 📝 정수 타입 (Integer Types)

- **`int`**: 가장 많이 사용되는 정수 타입. 4바이트 크기. 범위: -2,147,483,648 ~ 2,147,483,647
- **`long`**: 큰 정수를 저장할 때 사용. 8바이트 크기. 끝에 `L`을 붙여서 사용 (예: `10000000000L`)

### 📝 실수 타입 (Floating-Point Types)

- **`float`**: 단정밀도 실수. 4바이트. 끝에 `f`를 붙여서 사용 (예: `2.5f`)
- **`double`**: 배정밀도 실수. 8바이트. 더 정밀한 소수를 표현할 수 있습니다.

### 📝 문자와 문자열 타입

- **`char`**: 단일 문자. 2바이트. 작은따옴표로 묶음 (예: `'H'`)
- **`string`**: 문자열. 큰따옴표로 묶음 (예: `"Hello"`). 참조 타입입니다.

### 📝 논리 타입

- **`bool`**: 참(true) 또는 거짓(false)만 저장. 1바이트.

### 📝 열거형 (Enum)

열거형은 관련된 상수들의 집합을 정의할 때 사용합니다. 코드의 가독성을 높이고 실수를 줄여줍니다.

```csharp
internal enum BoxGrade
{
    NORMAL,    // 일반
    RARE,      // 레어
    EPIC,      // 에픽
    LEGENDARY  // 레전드
}
```

---

## 3. GiftBox 클래스 예시

`GiftBox` 클래스는 다양한 데이터 타입을 필드로 가지고 있습니다.

```csharp
class GiftBox
{
    public string Letter = "Happy Birthday!";  // 문자열
    public char FirstLetter = 'H';             // 단일 문자
    public int Money = 100;                    // 정수
    public long Distance = 10000000000L;       // 큰 정수
    public float Weight = 2.5f;                // 단정밀도 실수
    public double Height = 10.75;              // 배정밀도 실수
    public bool IsOpen = false;                // 논리값
    public BoxGrade Grade = BoxGrade.NORMAL;   // 열거형
}
```

---

## 4. 형 변환 (Type Conversion)

데이터 타입 간에 값을 변환하는 방법을 알아봅니다.

### 암시적 형 변환 (Implicit Conversion)
작은 타입에서 큰 타입으로의 변환은 자동으로 이루어집니다.

```csharp
float weight = 2.5f;
double height = weight;  // float -> double (자동 변환)

int smallNum = 10;
long bigNum = smallNum;  // int -> long (자동 변환)
```

### 명시적 형 변환 (Explicit Conversion)
큰 타입에서 작은 타입으로 변환할 때는 명시적으로 캐스트해야 합니다.

```csharp
double height = 10.75;
float weight = (float)height;  // double -> float (명시적 캐스트)

long bigNum = 10000000000L;
int smallNum = (int)bigNum;    // long -> int (명시적 캐스트, 값 손실 가능성)
```

### 문자열 변환

```csharp
int money = 100;
// int -> string
string moneyStr = money.ToString();
string moneyStr2 = money + "";

// string -> int
int parsedMoney = int.Parse(moneyStr);
bool success = int.TryParse(moneyStr, out int tryParsedMoney);  // 안전한 변환
```

---

## 5. 실행 예시

프로그램을 실행하면 다음과 같은 출력을 볼 수 있습니다.

```
Letter: Happy Birthday!, Grade: NORMAL
Letter: Congratulations!, Grade: RARE
Letter: Merry Christmas!, Grade: EPIC
1th letter: a
2th letter: p
...
Box Grade: RARE
100
200
200
300
300
```

---

## 6. 실행 방법

이 프로젝트를 실행하려면 컴퓨터에 .NET SDK가 설치되어 있어야 합니다.

1. 터미널 또는 명령 프롬프트를 엽니다.
2. 이 프로젝트 폴더(`DataType`)로 이동합니다.
3. 다음 명령어를 실행합니다.

```bash
dotnet run
```

콘솔에 다양한 데이터 타입의 값들이 출력되는 것을 확인할 수 있습니다.

---

이제 C#의 기본 데이터 타입에 대해 잘 이해하셨나요? 데이터 타입을 올바르게 선택하고 변환하는 것은 효율적인 프로그래밍의 기초입니다. 다음 단계로 넘어가기 전에 다양한 타입의 변수를 선언하고 사용해 보세요!
