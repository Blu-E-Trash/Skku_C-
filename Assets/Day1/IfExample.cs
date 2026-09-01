using UnityEngine;

public class IfExample : MonoBehaviour
{
    void Start()
    {



        /*
        if(조건식){ //만약 ~라면
            ~한다.
            조건식이 참(True)면 실행할 코드
        }
        else if(조건식){ //만약 ~라면
            ~한다.
            조건식이 참(True)면 실행할 코드
        }
        else{ 
            이도저도 아니라면 ~한다.
        }
         */

        //무조건 양수인 숫자가 짝수면 짝수! 홀수면 홀수! 0이면 0이라고 출력하는 코드를 작성해보기
        uint num = 7;
        
        if(num == 0)
        {
            Debug.Log("0!");
            return;
        }
        else if(num % 2 == 0)
        {
            Debug.Log("짝수!");
            return;
        }
        else
        {
            Debug.Log("홀수!");
            return;
        }

        //중첩 조건문
        // 조건문 안에 또 조건문이 들어가 있는 형태

        //ex) 로그인을 할 때, 아이디와 비밀번호를 입력받는다.
        //- 아이디를 입력하지 않으면 : " 존재하지 않는 ID입니다."
        //- 아이디를 입력했는데, 비밀번호가 없거나 틀리면 : "비밀번호가 틀렸습니다."
        //- 아이디와 비밀번호가 모두 맞으면 : "로그인 성공!"

        string userinputId = "admin";
        string userinputPassword = "4321";
        const string AdminId = "admin";
        const string AdminPassword = "1234";

        if(userinputId == AdminId)
        {
            if(userinputPassword == AdminPassword)
            {
                Debug.Log("관리자 로그인 성공!");
            }
            else
            {
                Debug.Log("비밀번호가 틀렸습니다.");
            }
        }
        else
        {
            Debug.Log("존재하지 않는 ID입니다.");
        }
    }
}
