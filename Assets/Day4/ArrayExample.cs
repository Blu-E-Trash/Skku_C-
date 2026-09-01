using System;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    private void Start()
    {
        // 배열: 같은 자료형의 데이터를 한 그룹으로 묶어서 사용하는 것
        // -> 연관된 데이터들을 모아서 관리하기 위해 사용

        int monsterHealth1 = 31;
        int monsterHealth2 = 28;
        int monsterHealth3 = 45;
        int monsterHealth4 = 52;

        //배열(변수) 선언
        //자료형[] 배열명 = new 자료형[크기(개수)]
        int[] monsterHealths = new int[] {31, 28, 45, 52, 66 };
        //-> int 자료형 50개를 담을 수 있는 연속된 메모리 공간이 할당(4byte * 50)
        //데이터 공간 하나하나를 보통 "Item"이라고 함
        // 이 아이템에 "접근"할 수 있는 랜덤 접근를 제공하는 데 이 순서를 "인덱스"라고 함

        monsterHealths[0] = 31;
        monsterHealths[1] = 28;
        monsterHealths[2] = 45;
        monsterHealths[3] = 30;
        monsterHealths[4] = 31;

        for(int i = 0; i < 5; i++)
        {
            Debug.Log($"몬스터 {i}의 체력: {monsterHealths[i]}");
        }

        // 배열의 속성과 기능
        int[] ages = new int[] { 30, 32, 27, 25 };
        Array.Sort( ages ); //-> 오름차순
        foreach(int age in ages)
        {
            Debug.Log(age); // 정렬이 됐는지 확인
        }
        Array.Reverse( ages ); // -> 내림차순
        foreach (int age in ages)
        {
            Debug.Log(age);
        }
    }
}
