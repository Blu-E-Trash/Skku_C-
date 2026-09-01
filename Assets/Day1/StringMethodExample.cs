using UnityEngine;

public class StringMethodExample : MonoBehaviour
{
    // 문자열은 문자열만의 여러가지 속성과 기능을 가지고 있음
    // 서식, 길이, 탐색, 변형, 분할
    void Start()
    {
        // 문자열 길이
        string name = "김메붕.";
        Debug.Log(name.Length); // 문자열 길이

        // 문자열은 불변식이므로 문자가 수정될때마다 새로 메모리를 할당한다.
        // 잘 하시길

        // 문자열 탐색
        string str = "안녕하세요, 제 이름은 김메붕입니다.";

        int index = str.IndexOf("김메붕"); // 문자열에서 특정 문자열의 인덱스(위치)를 반환, 없으면 -1 반환
        Debug.Log(index);
        bool isAn = name.StartsWith("안"); // 문자열이 특정 문자열로 시작하는지 확인
        Debug.Log(isAn);
        bool isContainKim = name.Contains("김"); // 문자열이 특정 문자열로 끝나는지 확인
        Debug.Log(isContainKim);

        // 변형 기능: 대소문자 변환, 문자열 추가, 대체, 삭제
        name = name.Insert(0, "아무것도 안했는데 벌써 288레벨인 "); // 문자열의 특정 위치에 문자열을 삽입
        Debug.Log(name);
        name = name.Trim(); // 문자열의 앞뒤 공백 제거
        name = name.Remove('.'); // 문자열에서 특정 문자를 제거')
        name = name.Replace("김메붕", "푸르른색뗏목"); // 문자열에서 특정 문자열을 다른 문자열로 대체
    }
}