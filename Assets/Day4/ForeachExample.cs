using UnityEngine;

public class ForEachExample : MonoBehaviour
{
    private void Start()
    {
        // 문자열: 문자를 순서대로 나'열' ( 문자배열)
        string myName = "황금독수리온세상을놀라게하다";
        Debug.Log(myName);
        Debug.Log(myName[0]); // 황
        Debug.Log(myName[1]); // 금
        Debug.Log(myName[myName.Length - 1]); // 다

        for(int i = 0; i < myName.Length; i++)
        {
            Debug.Log(myName[i]);
        }
        // foreach 문: 배열이나 컬렉션의 각 요소를 순회할 때 사용
        foreach (char c in myName)
        {
            Debug.Log(c);
        }
    }
}
