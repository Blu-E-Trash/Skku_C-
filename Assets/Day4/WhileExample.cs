using UnityEngine;

public class WhileExample : MonoBehaviour
{
    private void Start()
    {
        //while 문: 조건식이 참인 동안 반복문을 실행




        int i = 0;

        while (true)
        {
            Debug.Log("ㅎㅇ");
            i++; //증감식이 없으면, 무한히 실행되는 무한 루프에 빠져서 유니티가 멈춤게 됨
            if (i > 1000)
            {
                break; // 반복문을 종료하고 반복문 밖으로 점프
            }
        }

        //for: 반복하고자 하는 순서가 정해져 있어서 조건이 명확할 때
        //while: 반복하고자 하는 순서가 정해져 있지 않아서 조건이 명확하지 않을 때
    }
}
