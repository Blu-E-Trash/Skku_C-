using UnityEngine;

public class ForExample : MonoBehaviour
{
     void Start()
    {
        Debug.Log("ㅎㅇ");

        int sum = 0;

        // 1부터 1000까지 짝수만 더한 값을 출력
        for (int i = 1; i <= 1000; i++)
        {
            if (i % 2 == 0)
            {
                sum += i;
            }
        }
        Debug.Log(sum);

        // 구구단 2단~9단까지 5단을 제외하고 중첩 반복문을 이용해서 출력
        // 점프문: 반복문 내부에서 흐름을 끊고 코드 실행을 원하는 곳으로 점프해준다.
        // - break: 반복문을 종료하고 반복문 밖으로 점프 (종료/탈출이라고 부르기도 함)
        // - continue: 반복문을 종료하지 않고 반복문의 처음으로 점프

        for (int i = 2; i <= 9; i++)
        {
            if (i == 5)
            {
                continue;
            }

            for (int j = 1; j <= 9; j++)
            {
                Debug.Log($"{i} x {j} = {i * j}");
            }
        }
    }
}
