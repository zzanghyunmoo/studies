using System.ComponentModel;

namespace DataType;


class GiftBox
{
    // string: 문자들의 집합을 나타내는 데이터 타입, 참조 타입
    public string Letter = "Happy Birthday!";

    // char: 단일 문자를 나타내는 데이터 타입, 2바이트
    public char FirstLetter = 'H';

    // int: 정수를 나타내는 데이터 타입, 4바이트
    public int Money = 100;

    // long: 큰 정수를 나타내는 데이터 타입, 8바이트
    public long Distance = 10000000000L;

    // float: 소수를 나타내는 데이터 타입, 4바이트
    public float Weight = 2.5f;

    // double: 더 정밀한 소수를 나타내는 데이터 타입, 8바이트
    public double Height = 10.75;

    // bool: 참(true) 또는 거짓(false)을 나타내는 데이터 타입, 1바이트
    public bool IsOpen = false;

    // enum: 열거형 데이터 타입, 관련된 상수들의 집합을 정의
    public BoxGrade Grade = BoxGrade.NORMAL;
}
