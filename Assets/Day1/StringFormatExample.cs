using UnityEngine;

public class StringFormatExample : MonoBehaviour
{
    void Start()
    {
        string name = "김메붕";
        int age = 26;
        bool isMan = true;

        //1. + 연산자를 이용한 문자열 연결
        Debug.Log("안녕하세요, 제 이름은 " + name + "이고, 나이는 " + age + "살입니다. 성별은 " + (isMan ? "남자" : "여자") + "입니다.");

        // 2. 문자열 서식(String.Format)을 이용한 문자열 연결
        string gender = isMan ? "남자" : "여자";
        string intriduceString = string.Format("안녕하세요, 제 이름은 {0}이고, 나이는 {1}살입니다. 성별은 {2}입니다.", name, age, gender);
        Debug.Log(intriduceString);

        // 3. 문자열 보간(String Interpolation)을 이용한 문자열 연결
        string introduceString2 = $"안녕하세요, 제 이름은 {name}이고, 나이는 {age}살입니다. 성별은 {gender}입니다.";
        Debug.Log(introduceString2);

        int money = 6564321;
        float height = 171.543f;
        Debug.Log(height); // 171.543 // 그런데 나는 소수점 첫번째 자리만 출력을 하고싶다 -> 서식 문자열
        Debug.Log(money); // 6564321 // 그런데 나는 천단위마다 콤마(,)를 넣어서 출력하고싶다 -> 서식 문자열

        Debug.Log(string.Format("키: {0:F1}cm, 돈: {1:N0}원", height, money)); // F1: 소수점 첫번째 자리까지 출력, N0: 천단위마다 콤마(,)를 넣어서 출력
        Debug.Log($"키: {height:F1}cm, 돈: {money:N0}원"); // 문자열 보간을 이용한 서식 문자열

        int hour = 3;
        int minute = 13;
        // 03시 13분
        Debug.Log($"{hour:D2}시 {minute:D2}분"); // D2: 2자리로 출력, 1자리면 앞에 0을 붙여서 출력
    }
}
