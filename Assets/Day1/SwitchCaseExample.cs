using UnityEngine;

public class SwitchCaseExample : MonoBehaviour
{
    void Start()
    {
        //분기문
        // 내가 원하는 값과 같냐 다르냐에 따라서 실행할 코드 분기를 나눌 수 있다.

        /*
         switch(검사할 변수)
         {
             case 값1:
                 값이 값1과 같으면 실행할 코드
                 break;
             case 값2:
                 값이 값2와 같으면 실행할 코드
                 break;
             default:  //필수 아님
                 위의 case문에 해당하지 않으면 실행할 코드
                 break;
         }
         
         */
        // 변수 today를 선언하고.. 요일에 따라
        // "오늘은 **요일입니다:"를 출력해주는 코드
        DayOfWeek today = (DayOfWeek)System.DateTime.Now.DayOfWeek;

        //qustn Score를 선언하고 점수(0~100)에 따라
        // 100: "A+", 90~99: "A", 80~89: "B", 70~79: "C", 60~69: "D", 0~59: "F"를 출력해주는 코드
        int score = Random.Range(0, 101); // 예시 점수

        switch (today)
        {
            case DayOfWeek.Sunday:
                Debug.Log("오늘은 일요일입니다.");
                break;
            case DayOfWeek.Monday:
                Debug.Log("오늘은 월요일입니다.");
                break;
            case DayOfWeek.Tuesday:
                Debug.Log("오늘은 화요일입니다.");
                break;
            case DayOfWeek.Wednesday:
                Debug.Log("오늘은 수요일입니다.");
                break;
            case DayOfWeek.Thursday:
                Debug.Log("오늘은 목요일입니다.");
                break;
            case DayOfWeek.Friday:
                Debug.Log("오늘은 금요일입니다.");
                break;
            case DayOfWeek.Saturday:
                Debug.Log("오늘은 토요일입니다.");
                break;
        }
        switch (score / 10)
        {
            case 10:
                Debug.Log("A+");
                break;
            case 9:
                Debug.Log("A");
                break;
            case 8:
                Debug.Log("B");
                break;
            case 7:
                Debug.Log("C");
                break;
            case 6:
                Debug.Log("D");
                break;
            default:
                Debug.Log("F");
                break;
        }
    }
}
