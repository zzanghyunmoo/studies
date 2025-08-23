namespace ImplicitTypeConversion;

class Program
{
    static void Main(string[] args)
    {
        // 보통 암시적 형 변환은 작은 크기의 데이터 타입에서 큰 크기의 데이터 타입으로 변환될 때 발생합니다.
        int i1 = 10000;
        long l = i1;
        Console.WriteLine($"Implicitly converted long value: {i1} -> {l}");

        // 정밀도 손실: int/long -> float, long -> double 정밀도 손실 발생 가능함.
        int i2 = 1234567890;
        float f = i2;
        Console.WriteLine($"Implicitly converted float value: {i2} -> {f}; diff: {i2 - (int)f}");

        // 프로모션: 컴파일러가 자동으로 float, double 형으로 승격하는 것을 의미함.
        double d = 3.7;
        int i3 = 10;
        Console.WriteLine($"Promotion: {d + i3}");
    }
}
