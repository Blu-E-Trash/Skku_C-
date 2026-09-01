using UnityEngine;



// Enum: 열거형
// 열거: 순서대로 나열하는 것
// 관련 있는 숭수들을 한 줄로 쭉 나열해서 묶어놓는(그룹화한) 형태의 상수
// 요일(월, 화, 수, 목, 금, 토, 일), 계절(봄, 여름, 가을, 겨울) 등

// 요일 열거형 선언
// -> 

enum DayOfWeek
{
    Monday,     // 0
    Tuesday,    // 1
    Wednesday,  // 2
    Thursday,   // 3
    Friday,     // 4
    Saturday,   // 5
    Sunday      // 6
}
enum Season
{
    Spring,     // 0
    Summer,     // 1
    Autumn,     // 2
    Winter      // 3
}
enum KeyboardCode
{
    W,
    A,
    S,
    D,
    Alpha0
}

public class EnumExample : MonoBehaviour
{
    void Start()
    {
        DayOfWeek today = DayOfWeek.Thursday;
        if(today == DayOfWeek.Thursday) {
            Debug.Log("오늘은 목요일입니다.");
        }
        else
        {
            Debug.Log("오늘은 목요일이 아닙니다.");
        }

        Season todaySeason = Season.Summer;
        if(todaySeason == Season.Spring) {
            Debug.Log("이번 계절은 봄입니다.");
        }
        else
        {
            Debug.Log("이번 계절은 봄이 아닙니다.");
        }

    }
}
