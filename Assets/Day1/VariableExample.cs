using JetBrains.Annotations;
using UnityEngine; // 네임 스페이스

public class VariableExample : MonoBehaviour // 클래스
{
    void Start() // 함수(매서드)
    {
        /* 변수
        물건을 담을 수 있는 공간(상자)
        - 상자의 크기에 따라 담을 수 있는 물건의 크기 제한이 있음 (상자의 크기: 자료형의 크기)
        - 상자의 종류에 따라 담을 수 있는 물건의 종류가 다름 (상자의 종류: 자료형)
        - 상자의 이름을 변수명이라고 함 -> 일반적으로 변수라고 하면 변수명까지 포함하는 관계
         
         변수의 선언 : 데이터를 담을 필요한 공간을 메모리로부터 할당받는 과정
        - 크기                (자료형의 크기)
        - 공개 범위           (데이터의 공개 범위)
        - 타입                (자료형)
        - 이름                (변수명)
         -> <공개범위> [자료형] [변수명]
         */

        int health;
        int damage;
        float exp;
        double speed;
        string name;
        bool isDead;

        // 변수의 이름은 대, 소문자를 구분
        int Health; // 다른 변수로 인식

        //변수를 사용하기 전에 값을 미리 할당해 두는 것이 좋음 (초기화/초기값)
        //초기화 : 변수를 선언하면서 동시에 값을 할당하는 것
        // 초기값: 처음 초기화 할 때, 저장되는 값
        int age = 27;
        float height = 175.5f;
        double weight = 70.5;

        Debug.Log(age);
        Debug.Log(height);
        Debug.Log(weight);
    }
}
