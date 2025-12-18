using System.ComponentModel;

namespace DataType;

// internal 접근 제한자를 사용하여 동일 어셈블리 내에서만 접근 가능
internal enum BoxGrade
{
    // 열거형 상수에 한글 이름을 부여
    [Description("일반")] NORMAL,
    [Description("레어")] RARE,
    [Description("에픽")] EPIC,
    [Description("레전드")] LEGENDARY
}